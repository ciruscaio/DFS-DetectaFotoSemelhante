namespace DFS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFotoReferencia = new System.Windows.Forms.Button();
            this.fbdDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdFotoReferencia = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxForcaComparacao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoArquivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPercentualDeComparacao = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbrProgressoDoProcesso = new System.Windows.Forms.ProgressBar();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblDeletadas = new System.Windows.Forms.Label();
            this.lblProcessadas = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lbxListaDeImagens = new System.Windows.Forms.ListBox();
            this.btnSelecionarNada = new System.Windows.Forms.Button();
            this.btnSelecionarTudo = new System.Windows.Forms.Button();
            this.btnDeletarSelecionadas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foto(s) de Referência:";
            // 
            // btnFotoReferencia
            // 
            this.btnFotoReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoReferencia.Location = new System.Drawing.Point(128, 7);
            this.btnFotoReferencia.Name = "btnFotoReferencia";
            this.btnFotoReferencia.Size = new System.Drawing.Size(65, 23);
            this.btnFotoReferencia.TabIndex = 2;
            this.btnFotoReferencia.Text = "Adicionar";
            this.btnFotoReferencia.UseVisualStyleBackColor = true;
            this.btnFotoReferencia.Click += new System.EventHandler(this.btnFotoReferencia_Click);
            // 
            // fbdDiretorio
            // 
            this.fbdDiretorio.Description = "Onde deseja fazer a busca por semelhantes?";
            // 
            // ofdFotoReferencia
            // 
            this.ofdFotoReferencia.FileName = "ofdFotoReferencia";
            this.ofdFotoReferencia.Multiselect = true;
            this.ofdFotoReferencia.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFotoReferencia_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diretório de Busca:";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Enabled = false;
            this.txtDiretorio.Location = new System.Drawing.Point(117, 190);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(283, 20);
            this.txtDiretorio.TabIndex = 4;
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Location = new System.Drawing.Point(406, 188);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(75, 23);
            this.btnDiretorio.TabIndex = 5;
            this.btnDiretorio.Text = "Selecionar";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "[Rápido 25]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "[Ideal 1]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Força da Comp:";
            // 
            // cbxForcaComparacao
            // 
            this.cbxForcaComparacao.FormattingEnabled = true;
            this.cbxForcaComparacao.Items.AddRange(new object[] {
            ""});
            this.cbxForcaComparacao.Location = new System.Drawing.Point(117, 244);
            this.cbxForcaComparacao.Name = "cbxForcaComparacao";
            this.cbxForcaComparacao.Size = new System.Drawing.Size(80, 21);
            this.cbxForcaComparacao.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "[Alta Semmelhança 1 a 5%]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Arquivo:";
            // 
            // cbxTipoArquivo
            // 
            this.cbxTipoArquivo.FormattingEnabled = true;
            this.cbxTipoArquivo.Items.AddRange(new object[] {
            "*.jpg",
            "*.jpeg",
            "*.png",
            "*.gif"});
            this.cbxTipoArquivo.Location = new System.Drawing.Point(117, 271);
            this.cbxTipoArquivo.Name = "cbxTipoArquivo";
            this.cbxTipoArquivo.Size = new System.Drawing.Size(80, 21);
            this.cbxTipoArquivo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Perc. para Deleção:";
            // 
            // cbxPercentualDeComparacao
            // 
            this.cbxPercentualDeComparacao.FormattingEnabled = true;
            this.cbxPercentualDeComparacao.Location = new System.Drawing.Point(117, 217);
            this.cbxPercentualDeComparacao.Name = "cbxPercentualDeComparacao";
            this.cbxPercentualDeComparacao.Size = new System.Drawing.Size(80, 21);
            this.cbxPercentualDeComparacao.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(406, 305);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbrProgressoDoProcesso
            // 
            this.pbrProgressoDoProcesso.Location = new System.Drawing.Point(12, 308);
            this.pbrProgressoDoProcesso.Name = "pbrProgressoDoProcesso";
            this.pbrProgressoDoProcesso.Size = new System.Drawing.Size(256, 50);
            this.pbrProgressoDoProcesso.TabIndex = 7;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(406, 331);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 41);
            this.btnComparar.TabIndex = 8;
            this.btnComparar.Text = "Procurar e  Deletar!";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Processadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tempo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Deletadas:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(342, 321);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(13, 13);
            this.lblTempo.TabIndex = 12;
            this.lblTempo.Text = "0";
            // 
            // lblDeletadas
            // 
            this.lblDeletadas.AutoSize = true;
            this.lblDeletadas.Location = new System.Drawing.Point(342, 334);
            this.lblDeletadas.Name = "lblDeletadas";
            this.lblDeletadas.Size = new System.Drawing.Size(13, 13);
            this.lblDeletadas.TabIndex = 13;
            this.lblDeletadas.Text = "0";
            // 
            // lblProcessadas
            // 
            this.lblProcessadas.AutoSize = true;
            this.lblProcessadas.Location = new System.Drawing.Point(342, 347);
            this.lblProcessadas.Name = "lblProcessadas";
            this.lblProcessadas.Size = new System.Drawing.Size(13, 13);
            this.lblProcessadas.TabIndex = 14;
            this.lblProcessadas.Text = "0";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Location = new System.Drawing.Point(342, 308);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(13, 13);
            this.lblTaxa.TabIndex = 16;
            this.lblTaxa.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Taxa:";
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.Location = new System.Drawing.Point(342, 359);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(13, 13);
            this.lblTempoRestante.TabIndex = 18;
            this.lblTempoRestante.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(270, 359);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Tpo Restante:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "CaioBarbosa™ - Direitos Reservados, 2015, v2.0.";
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(2, 3);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(200, 148);
            this.pbxFoto.TabIndex = 19;
            this.pbxFoto.TabStop = false;
            // 
            // lbxListaDeImagens
            // 
            this.lbxListaDeImagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListaDeImagens.FormattingEnabled = true;
            this.lbxListaDeImagens.ItemHeight = 12;
            this.lbxListaDeImagens.Location = new System.Drawing.Point(12, 34);
            this.lbxListaDeImagens.Name = "lbxListaDeImagens";
            this.lbxListaDeImagens.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxListaDeImagens.Size = new System.Drawing.Size(256, 148);
            this.lbxListaDeImagens.TabIndex = 18;
            this.lbxListaDeImagens.Click += new System.EventHandler(this.lbxListaDeImagens_Click);
            // 
            // btnSelecionarNada
            // 
            this.btnSelecionarNada.Enabled = false;
            this.btnSelecionarNada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarNada.Location = new System.Drawing.Point(346, 7);
            this.btnSelecionarNada.Name = "btnSelecionarNada";
            this.btnSelecionarNada.Size = new System.Drawing.Size(65, 23);
            this.btnSelecionarNada.TabIndex = 22;
            this.btnSelecionarNada.Text = "Nada";
            this.btnSelecionarNada.UseVisualStyleBackColor = true;
            this.btnSelecionarNada.Click += new System.EventHandler(this.btnSelecionarNada_Click);
            // 
            // btnSelecionarTudo
            // 
            this.btnSelecionarTudo.Enabled = false;
            this.btnSelecionarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarTudo.Location = new System.Drawing.Point(276, 7);
            this.btnSelecionarTudo.Name = "btnSelecionarTudo";
            this.btnSelecionarTudo.Size = new System.Drawing.Size(65, 23);
            this.btnSelecionarTudo.TabIndex = 21;
            this.btnSelecionarTudo.Text = "Tudo";
            this.btnSelecionarTudo.UseVisualStyleBackColor = true;
            this.btnSelecionarTudo.Click += new System.EventHandler(this.btnSelecionarTudo_Click);
            // 
            // btnDeletarSelecionadas
            // 
            this.btnDeletarSelecionadas.Enabled = false;
            this.btnDeletarSelecionadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarSelecionadas.Location = new System.Drawing.Point(416, 7);
            this.btnDeletarSelecionadas.Name = "btnDeletarSelecionadas";
            this.btnDeletarSelecionadas.Size = new System.Drawing.Size(65, 23);
            this.btnDeletarSelecionadas.TabIndex = 20;
            this.btnDeletarSelecionadas.Text = "Deletar";
            this.btnDeletarSelecionadas.UseVisualStyleBackColor = true;
            this.btnDeletarSelecionadas.Click += new System.EventHandler(this.btnDeletarSelecionadas_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxFoto);
            this.panel1.Location = new System.Drawing.Point(276, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 148);
            this.panel1.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "[Pixels Errados 0.1 a 1%]";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 384);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelecionarNada);
            this.Controls.Add(this.btnSelecionarTudo);
            this.Controls.Add(this.btnDeletarSelecionadas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbxListaDeImagens);
            this.Controls.Add(this.lblTempoRestante);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxForcaComparacao);
            this.Controls.Add(this.lblProcessadas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDeletadas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.cbxTipoArquivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxPercentualDeComparacao);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.pbrProgressoDoProcesso);
            this.Controls.Add(this.btnDiretorio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFotoReferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecta Foto Semelhante - www.caiobarbosa.com.br";
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFotoReferencia;
        private System.Windows.Forms.FolderBrowserDialog fbdDiretorio;
        private System.Windows.Forms.OpenFileDialog ofdFotoReferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btnDiretorio;
        private System.Windows.Forms.ProgressBar pbrProgressoDoProcesso;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPercentualDeComparacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoArquivo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblDeletadas;
        private System.Windows.Forms.Label lblProcessadas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxForcaComparacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.ListBox lbxListaDeImagens;
        private System.Windows.Forms.Button btnSelecionarNada;
        private System.Windows.Forms.Button btnSelecionarTudo;
        private System.Windows.Forms.Button btnDeletarSelecionadas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
    }
}

