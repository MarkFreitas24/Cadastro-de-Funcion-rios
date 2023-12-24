namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            while (true)
            {
                Console.Write("Deseja cadastrar um funcionário(S/N)? ");
                char resp = char.Parse(Console.ReadLine().ToUpperInvariant());

                if (resp == 'S')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();

                    empresa.AdicionarFuncionario(nome, idade, cargo);
                }
                else if (resp == 'N')
                {
                    break;
                }
                else { Console.WriteLine("Comando inválido"); }
                Console.WriteLine();

            }

            Console.WriteLine();
            empresa.ImprimirFuncionarios();
            
            




        }
    }
}