# CursoInterface

Este repositório contém um projeto que demonstra a aplicação prática de interfaces em C#. Neste projeto, criamos uma interface chamada `IRegistro`, que define um método para registrar informações de diferentes maneiras.

## Funcionalidades

- **Interface IRegistro**: Define um contrato para classes que registram informações.
- **Classe RegistraOcorrencia**: Implementa a interface para registrar informações com data e hora.
- **Classe RegistrarNoArquivo**: Implementa a interface para registrar informações em um arquivo.

## Estrutura do Repositório


## Implementação da Interface

### IRegistro

```csharp
namespace CursoInterface.Interfaces
{
    public interface IRegistro
    {
        void RegistraInfo(string mensagem);
    }
}
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
