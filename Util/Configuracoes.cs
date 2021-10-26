using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Util;

namespace Util
{
    public class Configuracoes
    {
        private string gDiretorioAtual = Directory.GetCurrentDirectory().ToString();
        //private string diretorioAtual = @"C:\Users\Cirus\Desktop\Exercício";

        public static Configuracoes getConfiguracoes()
        {
            return new Configuracoes();
        }

        public C7CConfig rConfiguracoes(string pDiretorio_Opicional)
        {
            string lDiretorio = gDiretorioAtual;
            if (pDiretorio_Opicional != null)
            {
                lDiretorio = pDiretorio_Opicional;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(C7CConfig));
            StreamReader textReader = new StreamReader(lDiretorio + "\\configuracoes.c7cpconfig");
            C7CConfig lArquivo = serializer.Deserialize(textReader) as C7CConfig;
            textReader.Close();
            return lArquivo;
        }

        public void wConfiguracoes(C7CConfig pConfiguracoes)
        {
            //Só a primeira vez
            XmlSerializer serializer = new XmlSerializer(typeof(C7CConfig));
            StreamWriter writer = new StreamWriter(gDiretorioAtual + "\\configuracoes.c7cconfig");
            serializer.Serialize((TextWriter)writer, pConfiguracoes);
            writer.Close();
        }
    }

    public class C7CConfig
    {
        public string NomeSistema { get; set; }
        public string Diretorio { get; set; }
        
        public string Host { get; set; }
        public string Porta { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
    }
}
