namespace Programa
{
    public class PessoaController
    {

        public static void CriarPessoa()
        {
            Console.WriteLine("Digite o nome da pessoa");
            PessoaModel pessoa = new PessoaModel();
            pessoa.Nome = Console.ReadLine() ?? "";
            Console.WriteLine("Digite a idade da pessoa");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine("Criando Pessoa...");
            Pessoa.pessoas.Add(pessoa);
        }
        public static void ListarPessoas()
        {
            foreach (PessoaModel pessoa in Pessoa.pessoas)
            {
                Console.WriteLine($"nome: {pessoa.Nome}, Idade {pessoa.Idade}");
            }
        }
        public static void AlterarPessoa()
        {
            Console.WriteLine("Digite o indice da pessoa que você deseja alterar");
            int indice = Convert.ToInt32(Console.ReadLine());
            if (indice >= 0 && indice < Pessoa.pessoas.Count)
            {
                PessoaModel pessoa = Pessoa.pessoas[indice];
                Console.WriteLine($"Deseja alterar o nome[1] ou a idade[2] da pessoa: {Pessoa.pessoas[indice].Nome}");
                int resp = Convert.ToInt32(Console.ReadLine() ?? "");
                if (resp == 1)
                {
                    Console.WriteLine("Digite o novo valor de nome desta pessoa");
                    pessoa.Nome = Console.ReadLine() ?? "";
                }
                else if (resp == 2)
                {
                    Console.WriteLine("Digite o novo valor de idade desta pessoa");
                    pessoa.Idade = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Valor Inválido!");
                }
            }
            else
            {
                Console.WriteLine("Erro! Pessoa Não encontrada!");

            }
        }
        public static void DeletarPessoa()
        {
            Console.WriteLine("Digite o indice da pessoa que você deseja deletar");
            int indice = Convert.ToInt32(Console.ReadLine());
            if (indice >= 0 && indice < Pessoa.pessoas.Count)
            {
                Pessoa.pessoas.RemoveAt(indice);
                Console.WriteLine("Pessoa Removida");
            }
            else
            {
                Console.WriteLine("Pessoa Não encontrada!");
            }
        }
    }
}