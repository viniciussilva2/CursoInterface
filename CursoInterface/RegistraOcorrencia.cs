using CursoInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoInterface
{
    public class RegistraOcorrencia : IRegistro
    {

        private readonly IRegistro _registro;   

        public RegistraOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }
        
        public void RegistraInfo(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}
