namespace Programa
{
    public class PessoaView
    {

        public static int TelaPrincipal()
        {
            Console.WriteLine("Informe o que você deseja fazer: ");
            Console.WriteLine("1 - Para Criar uma pessoa");
            Console.WriteLine("2- para listar Pessoas ");
            Console.WriteLine("3- para Alterar uma Pessoa:  ");
            Console.WriteLine("4- Para Deletar uma pessoa: ");
            Console.WriteLine("5- para sair do App ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static void TelaCadastro() {
          
        }
    }
}