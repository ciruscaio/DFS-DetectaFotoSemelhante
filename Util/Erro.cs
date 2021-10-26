using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{
    public class Erro
    {
        static public void ExibirErro(Exception pException)
        {
            MessageBox.Show(pException.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
