using CursoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoInterface
{
    internal class RegistrarNoArquivo : IRegistro
    {
        private readonly string _caminhoNomeArquivo;

        public RegistrarNoArquivo(string path)
        {
            _caminhoNomeArquivo = path;
        }

        public void RegistraInfo(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using(var streamWriter = new StreamWriter(_caminhoNomeArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
                
       
    }
}
