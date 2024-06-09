using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Programa
{
    public class Pessoa
    {
        public static List<PessoaModel> pessoas = new List<PessoaModel>();
        static void Main()
        {
            int op = PessoaView.TelaPrincipal();

            do
            {

                switch (op)
                {
                    case 1:
                        PessoaController.CriarPessoa();
                        break;
                    case 2:
                        PessoaController.ListarPessoas();
                        break;
                    case 3:
                        PessoaController.AlterarPessoa();
                        break;
                    case 4:
                        PessoaController.DeletarPessoa();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Valor inválido! Tente novamente");
                        break;
                }

                op = PessoaView.TelaPrincipal();
            } while (op != 5);

        }
    }
}