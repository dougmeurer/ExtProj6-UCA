using System;
using System.Collections.Generic;

class Program
{
    class Setor
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; set; }

        public Setor(string nome)
        {
            Nome = nome;
            Funcionarios = new List<Funcionario>();
        }
    }

    class Funcionario
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string EstadoCivil { get; set; }
        public string TituloEleitoral { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string FormacaoEscolaridade { get; set; }
        public string CargoFuncao { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string JornadaTrabalho { get; set; }
        public decimal RemuneracaoSalarial { get; set; }
        public string Beneficios { get; set; }
        public string Ferias { get; set; }

        public Funcionario(
            string nome, DateTime dataNascimento, string naturalidade, string nacionalidade, string cpf, string rg,
            string estadoCivil, string tituloEleitoral, string endereco, string telefone, string formacaoEscolaridade,
            string cargoFuncao, DateTime dataAdmissao, string jornadaTrabalho, decimal remuneracaoSalarial, string beneficios,
            string ferias)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Naturalidade = naturalidade;
            Nacionalidade = nacionalidade;
            CPF = cpf;
            RG = rg;
            EstadoCivil = estadoCivil;
            TituloEleitoral = tituloEleitoral;
            Endereco = endereco;
            Telefone = telefone;
            FormacaoEscolaridade = formacaoEscolaridade;
            CargoFuncao = cargoFuncao;
            DataAdmissao = dataAdmissao;
            JornadaTrabalho = jornadaTrabalho;
            RemuneracaoSalarial = remuneracaoSalarial;
            Beneficios = beneficios;
            Ferias = ferias;
        }
    }

    static void Main(string[] args)
    {
        List<Setor> setores = new List<Setor>
        {
            new Setor("Financeiro"),
            new Setor("Operação"),
            new Setor("Atendimento")
        };

        setores[0].Funcionarios.Add(new Funcionario(
            "João Silva", new DateTime(1985, 5, 15), "São Paulo", "Brasileira", "12345678900", "MG1234567",
            "Solteiro", "1234567", "Rua A, 123", "11999999999", "Ensino Superior", "Analista Financeiro",
            new DateTime(2010, 1, 10), "40 horas/semana", 5000.00m, "VT, VR", "30 dias"));

        setores[0].Funcionarios.Add(new Funcionario(
            "Maria Oliveira", new DateTime(1990, 8, 25), "Rio de Janeiro", "Brasileira", "09876543210", "RJ7654321",
            "Casada", "7654321", "Rua B, 456", "21988888888", "Ensino Médio", "Assistente Financeiro",
            new DateTime(2015, 3, 12), "40 horas/semana", 3000.00m, "VT, VR", "30 dias"));

        setores[1].Funcionarios.Add(new Funcionario(
            "Pedro Santos", new DateTime(1982, 3, 14), "Belo Horizonte", "Brasileira", "11223344556", "BH1122334",
            "Casado", "1122334", "Rua C, 789", "31977777777", "Ensino Superior", "Gerente de Operações",
            new DateTime(2008, 6, 22), "44 horas/semana", 8000.00m, "VT, VR, Plano de Saúde", "30 dias"));

        setores[1].Funcionarios.Add(new Funcionario(
            "Ana Paula", new DateTime(1992, 11, 20), "Curitiba", "Brasileira", "66554433221", "PR6655443",
            "Solteira", "6655443", "Rua D, 101", "41966666666", "Ensino Médio", "Assistente de Operações",
            new DateTime(2017, 9, 5), "44 horas/semana", 3500.00m, "VT, VR", "30 dias"));

        setores[1].Funcionarios.Add(new Funcionario(
            "Lucas Pereira", new DateTime(1988, 7, 30), "Porto Alegre", "Brasileira", "44556677889", "RS4455667",
            "Casado", "4455667", "Rua E, 234", "51955555555", "Ensino Superior", "Supervisor de Operações",
            new DateTime(2012, 2, 19), "44 horas/semana", 6000.00m, "VT, VR, Plano de Saúde", "30 dias"));

        setores[2].Funcionarios.Add(new Funcionario(
            "Paulo Souza", new DateTime(1985, 4, 10), "Florianópolis", "Brasileira", "99887766554", "SC9988776",
            "Casado", "9988776", "Rua F, 567", "48944444444", "Ensino Superior", "Atendente",
            new DateTime(2011, 7, 25), "40 horas/semana", 2500.00m, "VT, VR", "30 dias"));

        setores[2].Funcionarios.Add(new Funcionario(
            "Carla Lima", new DateTime(1991, 9, 5), "Salvador", "Brasileira", "55443322110", "BA5544332",
            "Solteira", "5544332", "Rua G, 678", "71933333333", "Ensino Médio", "Atendente",
            new DateTime(2016, 4, 14), "40 horas/semana", 2500.00m, "VT, VR", "30 dias"));

        setores[2].Funcionarios.Add(new Funcionario(
            "Beatriz Araújo", new DateTime(1987, 12, 19), "Fortaleza", "Brasileira", "33221100998", "CE3322110",
            "Casada", "3322110", "Rua H, 789", "85922222222", "Ensino Superior", "Atendente",
            new DateTime(2013, 11, 7), "40 horas/semana", 2500.00m, "VT, VR", "30 dias"));

        setores[2].Funcionarios.Add(new Funcionario(
            "Carlos Eduardo", new DateTime(1994, 1, 23), "Manaus", "Brasileira", "77665544332", "AM7766554",
            "Solteiro", "7766554", "Rua I, 890", "92911111111", "Ensino Médio", "Atendente",
            new DateTime(2019, 8, 20), "40 horas/semana", 2500.00m, "VT, VR", "30 dias"));

        setores[2].Funcionarios.Add(new Funcionario(
            "Fernanda Silva", new DateTime(1996, 3, 15), "Recife", "Brasileira", "11224433556", "PE1122443",
            "Solteira", "1122443", "Rua J, 123", "81900000000", "Ensino Médio", "Atendente",
            new DateTime(2020, 12, 1), "40 horas/semana", 2500.00m, "VT, VR", "30 dias"));

        while (true)
        {
            Console.WriteLine("\nGestão de Pessoas - Menu");
            Console.WriteLine("1. Visualizar funcionários por setor");
            Console.WriteLine("2. Adicionar setor");
            Console.WriteLine("3. Remover setor vazio");
            Console.WriteLine("4. Adicionar funcionário");
            Console.WriteLine("5. Remover funcionário");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    VisualizarFuncionariosPorSetor(setores);
                    break;
                case 2:
                    AdicionarSetor(setores);
                    break;
                case 3:
                    RemoverSetorVazio(setores);
                    break;
                case 4:
                    AdicionarFuncionario(setores);
                    break;
                case 5:
                    RemoverFuncionario(setores);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void VisualizarFuncionariosPorSetor(List<Setor> setores)
    {
        Console.WriteLine("\nSetores disponíveis:");
        for (int i = 0; i < setores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {setores[i].Nome}");
        }
        Console.Write("Escolha um setor para visualizar os funcionários: ");
        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > setores.Count)
        {
            Console.WriteLine("Setor inválido.");
            return;
        }

        Setor setor = setores[escolha - 1];
        Console.WriteLine($"Funcionários do setor {setor.Nome}: \n");
        foreach (var funcionario in setor.Funcionarios)
        {
            Console.WriteLine($"Nome: {funcionario.Nome},\n" +
                              $"Data de Nascimento: {funcionario.DataNascimento.ToShortDateString()},\n" +
                              $"Naturalidade: {funcionario.Naturalidade},\n" +
                              $"Nacionalidade: {funcionario.Nacionalidade},\n" +
                              $"CPF: {funcionario.CPF},\n" +
                              $"RG: {funcionario.RG},\n" +
                              $"Estado Civil: {funcionario.EstadoCivil},\n" +
                              $"Título Eleitoral: {funcionario.TituloEleitoral},\n" +
                              $"Endereço: {funcionario.Endereco},\n" +
                              $"Telefone: {funcionario.Telefone},\n" +
                              $"Formação/Escolaridade: {funcionario.FormacaoEscolaridade},\n" +
                              $"Cargo/Função: {funcionario.CargoFuncao},\n" +
                              $"Data de Admissão: {funcionario.DataAdmissao.ToShortDateString()},\n" +
                              $"Jornada de Trabalho: {funcionario.JornadaTrabalho},\n" +
                              $"Remuneração Salarial: {funcionario.RemuneracaoSalarial:C},\n" +
                              $"Benefícios: {funcionario.Beneficios},\n" +
                              $"Férias: {funcionario.Ferias}\n");
        }
    }

    static void AdicionarSetor(List<Setor> setores)
    {
        Console.Write("Digite o nome do novo setor: ");
        string nomeSetor = Console.ReadLine();
        setores.Add(new Setor(nomeSetor));
        Console.WriteLine("Setor adicionado com sucesso.");
    }

    static void RemoverSetorVazio(List<Setor> setores)
    {
        Console.WriteLine("\nSetores disponíveis:");
        for (int i = 0; i < setores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {setores[i].Nome} (Funcionários: {setores[i].Funcionarios.Count})");
        }
        Console.Write("Escolha um setor vazio para remover: ");
        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > setores.Count)
        {
            Console.WriteLine("Setor inválido.");
            return;
        }

        Setor setor = setores[escolha - 1];
        if (setor.Funcionarios.Count == 0)
        {
            setores.Remove(setor);
            Console.WriteLine("Setor removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Setor não está vazio. Não pode ser removido.");
        }
    }

    static void AdicionarFuncionario(List<Setor> setores)
    {
        Console.WriteLine("\nSetores disponíveis:");
        for (int i = 0; i < setores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {setores[i].Nome}");
        }
        Console.Write("Escolha um setor para adicionar um funcionário: ");
        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > setores.Count)
        {
            Console.WriteLine("Setor inválido.");
            return;
        }

        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a data de nascimento (dd/mm/yyyy): ");
        DateTime dataNascimento;
        if (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.WriteLine("Data inválida.");
            return;
        }
        Console.Write("Digite a naturalidade: ");
        string naturalidade = Console.ReadLine();
        Console.Write("Digite a nacionalidade: ");
        string nacionalidade = Console.ReadLine();
        Console.Write("Digite o CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Digite o RG: ");
        string rg = Console.ReadLine();
        Console.Write("Digite o estado civil: ");
        string estadoCivil = Console.ReadLine();
        Console.Write("Digite o título eleitoral: ");
        string tituloEleitoral = Console.ReadLine();
        Console.Write("Digite o endereço: ");
        string endereco = Console.ReadLine();
        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine();
        Console.Write("Digite a formação ou escolaridade: ");
        string formacaoEscolaridade = Console.ReadLine();
        Console.Write("Digite o cargo e função: ");
        string cargoFuncao = Console.ReadLine();
        Console.Write("Digite a data de admissão (dd/mm/yyyy): ");
        DateTime dataAdmissao;
        if (!DateTime.TryParse(Console.ReadLine(), out dataAdmissao))
        {
            Console.WriteLine("Data inválida.");
            return;
        }
        Console.Write("Digite a jornada de trabalho: ");
        string jornadaTrabalho = Console.ReadLine();
        Console.Write("Digite a remuneração salarial: ");
        decimal remuneracaoSalarial;
        if (!decimal.TryParse(Console.ReadLine(), out remuneracaoSalarial))
        {
            Console.WriteLine("Valor inválido para remuneração.");
            return;
        }
        Console.Write("Digite os benefícios: ");
        string beneficios = Console.ReadLine();
        Console.Write("Digite as férias: ");
        string ferias = Console.ReadLine();

        setores[escolha - 1].Funcionarios.Add(new Funcionario(
            nome, dataNascimento, naturalidade, nacionalidade, cpf, rg, estadoCivil, tituloEleitoral, endereco,
            telefone, formacaoEscolaridade, cargoFuncao, dataAdmissao, jornadaTrabalho, remuneracaoSalarial,
            beneficios, ferias));

        Console.WriteLine("Funcionário adicionado com sucesso.");
    }

    static void RemoverFuncionario(List<Setor> setores)
    {
        Console.WriteLine("\nSetores disponíveis:");
        for (int i = 0; i < setores.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {setores[i].Nome}");
        }
        Console.Write("Escolha um setor para remover um funcionário: ");
        int escolha;
        if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > setores.Count)
        {
            Console.WriteLine("Setor inválido.");
            return;
        }

        Setor setor = setores[escolha - 1];
        Console.WriteLine($"Funcionários do setor {setor.Nome}:");
        for (int i = 0; i < setor.Funcionarios.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {setor.Funcionarios[i].Nome}");
        }
        Console.Write("Escolha um funcionário para remover: ");
        int escolhaFuncionario;
        if (!int.TryParse(Console.ReadLine(), out escolhaFuncionario) || escolhaFuncionario < 1 || escolhaFuncionario > setor.Funcionarios.Count)
        {
            Console.WriteLine("Funcionário inválido.");
            return;
        }

        setor.Funcionarios.RemoveAt(escolhaFuncionario - 1);
        Console.WriteLine("Funcionário removido com sucesso.");
    }
}
