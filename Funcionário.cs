namespace Cadastro
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Cargo { get; private set; }

        public Funcionario(string nome, int idade, string cargo)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
        }
    }
}