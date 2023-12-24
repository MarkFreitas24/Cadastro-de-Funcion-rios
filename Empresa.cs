namespace Cadastro
{
    internal class Empresa
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void AdicionarFuncionario(string nome, int idade, string cargo)
        {
            if(!NomeExistente(nome) && !IdadeNegativa(idade))
            {
                Funcionario novoFuncionario = new Funcionario(nome, idade, cargo);
                funcionarios.Add(novoFuncionario);
                Console.WriteLine("Funcionário adicionado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Você não pode adicionar um nome já existente ou uma idade negativa.\n Por favor, adicione um novo Funcionário válido");
            }
            
        }
        private bool NomeExistente(string nome)
        {
            return funcionarios.Any(funcionario => funcionario.Nome == nome);
        }

        private bool IdadeNegativa(int idade)
        {
            return idade < 0;
        }

        public void ImprimirFuncionarios()
        {
            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine($"Nome: {funcionario.Nome}\nIdade: {funcionario.Idade}\nCargo: {funcionario.Cargo}");
                Console.WriteLine();
            }
        }
    }
}