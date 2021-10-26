using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS.Dto
{
    public class Imagem
    {
        public string Nome { get; set; }
        public string NomeSemExtencao { get; set; }
        public string Endereco { get; set; }
        public double PercentualDeSemelhanca { get; set; }
        public bool Deletar { get; set; }
        public Image Img { get; set; }

    }
}
