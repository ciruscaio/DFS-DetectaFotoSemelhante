using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Util
{
    public class Arquivo : LiberarMemoria
    {
        public static Arquivo getArquivo()
        {
            return new Arquivo();
        }

        public bool VerificaSeExisteArquivo(string pArquivo)
        {
            try
            {
                FileInfo file = new FileInfo(pArquivo);

                if (file.Exists)
                    return true;
                else
                    return false;
            }
            finally
            {
                Dispose();
            }
        }

        public void CriaArquivo(string pArquivo)
        {
            try
            {
                if (VerificaSeExisteArquivo(pArquivo) == false)
                {
                    System.IO.File.Create(pArquivo);
                }
            }
            finally
            {
                Dispose();
            }
        }

        public void DeletarArquivo(string pArquivo)
        {
            try
            {
                if (VerificaSeExisteArquivo(pArquivo) == true)
                {
                    System.IO.File.Delete(pArquivo);
                }
            }
            finally
            {
                Dispose();
            }
        }

        public void MoverArquivo(string pArquivo, string pDestino)
        {
            try
            {
                if (VerificaSeExisteArquivo(pArquivo) == true)
                {
                    System.IO.File.Move(pArquivo, pDestino);
                }
            }
            finally
            {
                Dispose();
            }
        }

        public void CopiarArquivo(string pArquivoOriginal, string pPastaDestino, string pNomeNovoArquivo)
        {
            try
            {
                if (VerificaSeExisteArquivo(pArquivoOriginal))
                {
                    if (string.IsNullOrEmpty(pPastaDestino))
                    {
                        if (VerificaSeExisteArquivo(System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + ".jpg"))
                        {
                            DeletarArquivo(System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + ".jpg");
                        }
                        System.IO.File.Copy(pArquivoOriginal, System.IO.Path.GetDirectoryName(pArquivoOriginal) + "\\" + pNomeNovoArquivo + ".jpg");
                    }
                    else
                    {
                        if (VerificaSeExisteArquivo(pPastaDestino + "\\" + pNomeNovoArquivo + ".jpg"))
                        {
                            DeletarArquivo(pPastaDestino + "\\" + pNomeNovoArquivo + ".jpg");
                        }
                        System.IO.File.Copy(pArquivoOriginal, pPastaDestino + "\\" + pNomeNovoArquivo + ".jpg");
                    }                    
                }
            }
            finally
            {
                Dispose();
            }
        }
    }
}
