using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFS.Dto;
using Util;

namespace DFS
{
    public partial class frmPrincipal : Form
    {
        List<Imagem> gImagensDeReferencia;

        public frmPrincipal()
        {
            InitializeComponent();

            //AÇÕES DE INICIALIZAÇÃO
            SetarPadroesDeInterface();
            CarregarCbxPercentualDeComparacao();
            CarregarCbxForcaComparacao();
        }

        //INICIALIZAÇÃO
        private void CarregarCbxPercentualDeComparacao()
        {
            try
            {
                List<double> Valores = new List<double>();

                //Adiciona decimais
                for (double i = 0.1; i < 10; i = i + 0.1)
                {
                    Valores.Add(Math.Round(i, 1));
                }
                //Adiciona 11 a 20
                for (int i = 11; i <= 20; i++)
                {
                    Valores.Add(i);
                }
                //Adiciona 25 a 50
                for (int i = 25; i < 50; i = i + 5)
                {
                    Valores.Add(i);
                }
                //Adiciona 60 a 100
                for (int i = 60; i <= 100; i = i + 10)
                {
                    Valores.Add(i);
                }

                cbxPercentualDeComparacao.DataSource = Valores;
            }
            catch
            {
                return;
            }
        }
        private void CarregarCbxForcaComparacao()
        {
            try
            {
                List<double> Valores = new List<double>();

                Valores.Add(1);
                //Adiciona decimais
                for (int i = 5; i < 105; i = i + 5)
                {
                    Valores.Add(i);
                }

                cbxForcaComparacao.DataSource = Valores;
            }
            catch
            {
                return;
            }
        }

        //AÇÕES
        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdDiretorio.ShowDialog() == DialogResult.OK)
                {
                    txtDiretorio.Text = fbdDiretorio.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                lbxListaDeImagens.DataSource = null;
                lbxListaDeImagens.Refresh();
                pbxFoto.Image = null;
                txtDiretorio.Text = "";
                cbxPercentualDeComparacao.Text = "";
                cbxForcaComparacao.Text = "";
                cbxTipoArquivo.Text = "";
                btnSelecionarTudo.Enabled = false;
                btnSelecionarNada.Enabled = false;
                btnDeletarSelecionadas.Enabled = false;
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void btnComparar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validações
                ValidarFormulario();

                //Tempo
                DateTime lTempo_Inicio = DateTime.Now;

                //Diretório a ser listado
                DirectoryInfo diretorio = new DirectoryInfo(txtDiretorio.Text);

                //Executa função GetFile(Lista os arquivos desejados de acordo com o parametro)
                List<Dto.Imagem> lImagens = ConverterEmListaDeImagens(diretorio.GetFiles(cbxTipoArquivo.SelectedItem.ToString()));

                //Copia a imagem de referência
                //Path.GetTempPath
                foreach (var fImagem in gImagensDeReferencia)
                {
                    Util.Arquivo.getArquivo().CopiarArquivo(fImagem.Endereco, Path.GetTempPath(), "DFSImagemReferencia_" + fImagem.NomeSemExtencao.ToString());
                }

                //Motor de Comparação
                #region Declarações do Motor de Comparação
                int lContaProcessados = 0;
                int lContaDeletados = 0;
                int lHoras = 0;
                int lMinutos = 0;
                int lSegundos = 0;
                int lForcaComparacao = Convert.ToInt32(cbxForcaComparacao.Text);
                double lTaxaProcessamento = 0;
                pbrProgressoDoProcesso.Maximum = lImagens.Count * gImagensDeReferencia.Count; //Iniciando o ProgressBar - imagens a serem processadas x imagens a serem comparadas
                Bitmap ImagemReferencia = null; //new Bitmap(Path.GetTempPath() + "DFSImagemReferencia.jpg");
                Bitmap ImagemEmComparacao = null;
                double lPercentualDeSemelhancaDetectado;
                double lPercentualParaDelecao = Convert.ToDouble(cbxPercentualDeComparacao.Text);
                string lEnderecoParaDelecao = string.Empty; //artifício, pois quando for deletar a imagem o endereço fica indisponível
                #endregion
                foreach (var fImgagemReferencia in gImagensDeReferencia)
                {
                    //Reiniciando variáveis a cada laço de imagens de referência
                    ImagemReferencia = new Bitmap(Path.GetTempPath() + "DFSImagemReferencia_" + fImgagemReferencia.Nome.ToString());
                    lPercentualDeSemelhancaDetectado = 0;
                    lEnderecoParaDelecao = string.Empty;

                    //Laço que pega uma imagem de referência do nível anterior e compara com todas as imagens em questão
                    foreach (var fImagem in lImagens)
                    {
                        lContaProcessados++;

                        int contatador_pixelssemelhantes = 0;

                        ImagemEmComparacao = new Bitmap(fImagem.Endereco);

                        if (ImagemReferencia.Width == ImagemEmComparacao.Width && ImagemReferencia.Height == ImagemEmComparacao.Height)
                        {
                            int lContador_TotalDePixels = (ImagemReferencia.Width * ImagemReferencia.Height);

                            //Buscar pixels errados
                            for (int i = 0; i < ImagemReferencia.Width; i = i + lForcaComparacao)
                            {
                                for (int j = 0; j < ImagemReferencia.Height; j = j + lForcaComparacao)
                                {
                                    if (ImagemReferencia.GetPixel(i, j).Name == ImagemEmComparacao.GetPixel(i, j).Name)
                                    {
                                        contatador_pixelssemelhantes++;
                                    }
                                }
                            }

                            lPercentualDeSemelhancaDetectado = (Convert.ToDouble(contatador_pixelssemelhantes) / Convert.ToDouble(lContador_TotalDePixels / (lForcaComparacao * lForcaComparacao))) * Convert.ToDouble(100);

                            //Deletando, caso atenda a especificação
                            if (lPercentualDeSemelhancaDetectado >= lPercentualParaDelecao)
                            {
                                lContaDeletados++;

                                lEnderecoParaDelecao = fImagem.Endereco;

                                ImagemEmComparacao.Dispose();

                                Util.Arquivo.getArquivo().DeletarArquivo(lEnderecoParaDelecao);

                                //Util.Arquivo.getArquivo().MoverArquivo(lEnderecoParaDelecao, System.IO.Path.GetDirectoryName(lEnderecoParaDelecao) + "\\DELETAR\\" + System.IO.Path.GetFileName(lEnderecoParaDelecao));
                            }
                        }

                        ImagemEmComparacao.Dispose();

                        //Cuidadando do ProgressBar e Dados
                        #region Cuidadando do ProgressBar e Dados
                        if (pbrProgressoDoProcesso.Value < pbrProgressoDoProcesso.Maximum)
                        {
                            pbrProgressoDoProcesso.Value++;
                        }
                        #region Apresentação do Tempo
                        //Math.Round((DateTime.Now.Subtract(lTempo_Inicio).TotalMinutes),0).ToString();

                        lSegundos = Convert.ToInt32((DateTime.Now.Subtract(lTempo_Inicio).TotalSeconds));
                        lMinutos = Convert.ToInt32((DateTime.Now.Subtract(lTempo_Inicio).TotalMinutes));
                        lHoras = Convert.ToInt32((DateTime.Now.Subtract(lTempo_Inicio).TotalHours));

                        lblTempo.Text = lHoras.ToString() + ":" + minutos(lMinutos).ToString() + ":" + segundos(lSegundos).ToString();
                        #endregion
                        #region Apresentação da Taxa de Processamento
                        lTaxaProcessamento = (Math.Round((Convert.ToDouble(lContaProcessados) / Convert.ToDouble(lSegundos)), 2));
                        if (!double.IsInfinity(lTaxaProcessamento))
                        {
                            lblTaxa.Text = Convert.ToInt32(lTaxaProcessamento).ToString() + " f/s";
                        }
                        #endregion
                        #region Apresentação do TempoRestante

                        lSegundos = Convert.ToInt32(Convert.ToDouble(lImagens.Count - lContaProcessados) / lTaxaProcessamento);
                        lMinutos = Convert.ToInt32((Convert.ToDouble(lImagens.Count - lContaProcessados) / lTaxaProcessamento) / 60);
                        lHoras = Convert.ToInt32((Convert.ToDouble(lImagens.Count - lContaProcessados) / lTaxaProcessamento) / 3600);

                        lblTempoRestante.Text = lHoras.ToString() + ":" + minutos(lMinutos).ToString() + ":" + segundos(lSegundos).ToString();
                        //(Convert.ToDouble(lImagens.Count - lContaProcessados) / lTaxaProcessamento).ToString() + "s";
                        #endregion
                        lblDeletadas.Text = lContaDeletados.ToString();
                        lblProcessadas.Text = lContaProcessados.ToString();
                        #endregion

                        ImagemReferencia.Dispose();
                        AtualizarInterface();
                    }
                    
                }
                
                //FINALIZAÇÕES
                //Limpar Progress Barr
                pbrProgressoDoProcesso.Value = 0;
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }

        //TEMPO
        private int minutos(int pMinutos)
        {
            if (pMinutos < 60)
            {
                return pMinutos;
            }
            else
            {
                return (pMinutos % 60);
            }
        }
        private int segundos(int pSegundos)
        {
            if (pSegundos < 60)
            {
                return pSegundos;
            }
            else
            {
                return (pSegundos % 60);
            }
        }

        //ARQUIVOS (FILE DIALOG)
        private void btnFotoReferencia_Click(object sender, EventArgs e)
        {
            try
            {
                ofdFotoReferencia.ShowDialog();
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void ofdFotoReferencia_FileOk(object sender, CancelEventArgs e)
        {
            try
            {

                //Obtendo a lista de imagens                
                gImagensDeReferencia = new List<Imagem>();
                Imagem lImagem;
                foreach (String file in ofdFotoReferencia.FileNames)
                {
                    lImagem = new Imagem();
                    lImagem.Img = Image.FromFile(file);
                    lImagem.Nome = file.Split('\\')[file.Split('\\').Length - 1];
                    lImagem.NomeSemExtencao = lImagem.Nome.Split('.')[lImagem.Nome.Split('.').Length - 2];
                    lImagem.Endereco = file;

                    gImagensDeReferencia.Add(lImagem);
                    AtualizarInterface();
                }

                //Mostrar no ListBox
                AtualizarListaDeImagens();

                //Obtendo a pasta
                txtDiretorio.Text = ObterPastaDoFileDialog(ofdFotoReferencia.FileNames[0]);
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }

        //CONTROLE DA LISTA DE IMAGENS
        private void btnSelecionarNada_Click(object sender, EventArgs e)
        {
            try
            {
                List<Dto.Imagem> lArquivos = new List<Dto.Imagem>(lbxListaDeImagens.Items.OfType<Dto.Imagem>().ToList());

                int aux = 0;
                foreach (var fArquivo in lArquivos)
                {
                    lbxListaDeImagens.SetSelected(aux, false);

                    aux++;

                    AtualizarInterface();
                }
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Dto.Imagem> lArquivos = new List<Dto.Imagem>(lbxListaDeImagens.Items.OfType<Dto.Imagem>().ToList());

                int aux = 0;
                foreach (var fArquivo in lArquivos)
                {
                    lbxListaDeImagens.SetSelected(aux, true);

                    aux++;

                    AtualizarInterface();
                }
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void btnDeletarSelecionadas_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var fImagem in lbxListaDeImagens.SelectedItems)
                {
                    gImagensDeReferencia.Remove((Imagem)fImagem);
                }

                AtualizarListaDeImagens();

                AtualizarInterface();
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void lbxListaDeImagens_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox lListBox = sender as ListBox;
                if (Util.Arquivo.getArquivo().VerificaSeExisteArquivo(txtDiretorio.Text + "\\" + lListBox.Text))
                {
                    pbxFoto.Load(txtDiretorio.Text + "\\" + lListBox.Text);
                }
                pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                return;
            }
        }

        //FUNÇÕES
        private void AtualizarListaDeImagens()
        {
            lbxListaDeImagens.DataSource = null;
            lbxListaDeImagens.DisplayMember = "Nome";
            lbxListaDeImagens.DataSource = gImagensDeReferencia;

            //Seta a primeira foto para aparecer no PictureBox
            if (gImagensDeReferencia.Count > 0)
            {
                pbxFoto.Load(gImagensDeReferencia[0].Endereco);
                pbxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }

            //Habilita/desabilita os botões para mudar a lista de imagem
            //Limpa o picture box
            if (lbxListaDeImagens.Items.Count > 0)
            {
                //Habilita botões
                btnSelecionarTudo.Enabled = true;
                btnSelecionarNada.Enabled = true;
                btnDeletarSelecionadas.Enabled = true;
            }
            else
            {
                //Desabilita botões
                btnSelecionarTudo.Enabled = false;
                btnSelecionarNada.Enabled = false;
                btnDeletarSelecionadas.Enabled = false;

                //Limpa picture box
                pbxFoto.Image = null;
            }
        }
        private List<Dto.Imagem> ConverterEmListaDeImagens(FileInfo[] pArquivos)
        {
            Dto.Imagem lImagem = null;
            List<Dto.Imagem> lImagens = new List<Dto.Imagem>();
            foreach (FileInfo fileinfo in pArquivos)
            {
                lImagem = new Dto.Imagem();

                lImagem.Nome = fileinfo.Name;
                lImagem.Endereco = txtDiretorio.Text + "\\" + fileinfo.Name;
                lImagem.Deletar = false;

                lImagens.Add(lImagem);
            }

            return lImagens;
        }
        private void SetarPadroesDeInterface()
        {
            try
            {
                cbxPercentualDeComparacao.Text = "20";
                cbxForcaComparacao.Text = "1";
                cbxTipoArquivo.Text = "*.jpg";
            }
            catch (Exception ex)
            {
                Util.Erro.ExibirErro(ex);
            }
        }
        private void ValidarFormulario()
        {
            if (lbxListaDeImagens.Items.Count == 0)
            {
                throw new Exception("Foto(s) de Referência é(são) requerida(s)!");
            }
            if (txtDiretorio.Text == "")
            {
                throw new Exception("Diretório de Busca é requerido!");
            }
            if (cbxPercentualDeComparacao.Text == "")
            {
                throw new Exception("Percentual é requerido!");
            }
            if (cbxForcaComparacao.Text == "")
            {
                throw new Exception("Força da Comparação é requerido!");
            }
            if (cbxTipoArquivo.Text == "")
            {
                throw new Exception("Tipo de Arquivo é requerido!");
            }
        }
        private string ObterPastaDoFileDialog(string pCaminhoFisicoDoArquivo)
        {
            string[] lListaPartesDaString = pCaminhoFisicoDoArquivo.Split('\\');
            string lCaminhoDaPasta = "";

            for (int i = 0; i < lListaPartesDaString.Length - 1; i++)
            {
                if (i == 0)
                {
                    lCaminhoDaPasta += lListaPartesDaString[i];
                }
                else
                {
                    lCaminhoDaPasta += "\\" + lListaPartesDaString[i];
                }
            }

            return lCaminhoDaPasta;
        }
        private void AtualizarInterface()
        {
            //Garantindo o não travamento
            Thread.Sleep(5);
            System.Windows.Forms.Application.DoEvents();
        }

        //QUERYS
        private List<Dto.Imagem> ObterImagensParaDelecao(List<Dto.Imagem> pImagens)
        {
            List<Dto.Imagem> lImagens = new List<Dto.Imagem>();

            foreach (var fImagem in pImagens)
            {
                if (fImagem.Deletar == true)
                {
                    lImagens.Add(fImagem);
                }
            }

            return lImagens;
        }

    }
}
