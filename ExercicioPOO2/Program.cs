using ExercicioPOO2;

List<Cliente> clientes = new List<Cliente>();

int opcao;
do
{
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1. Cadastrar cliente");
    Console.WriteLine("2. Exibir informações da conta");
    Console.WriteLine("3. Realizar depósito");
    Console.WriteLine("4. Realizar retirada");
    Console.WriteLine("5. Sair");
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;
        case 2:
            ExibirInformacoesConta();
            break;
        case 3:
            RealizarDeposito();
            break;
        case 4:
            RealizarRetirada();
            break;
        case 5:
            Console.WriteLine("Encerrando o Sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida. Digite novamente por favor!");
            Console.WriteLine();
            break;
    }
} while (opcao != 5);


void CadastrarCliente()
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o CPF do cliente: ");
    string cpf = Console.ReadLine();
    Console.WriteLine("Selecione o tipo de conta:");
    Console.WriteLine("1. Conta Corrente");
    Console.WriteLine("2. Conta Poupança");
    Console.WriteLine("3. Conta Salário");
    Console.Write("Opção: ");
    int tipoConta = int.Parse(Console.ReadLine());

    IConta conta;
    switch (tipoConta)
    {
        case 1:
            Console.Write("Digite o número da conta corrente: ");
            string numeroContaCorrente = Console.ReadLine();
            conta = new Corrente(numeroContaCorrente);
            break;
        case 2:
            Console.Write("Digite o número da conta poupança: ");
            string numeroContaPoupanca = Console.ReadLine();
            conta = new Poupanca(numeroContaPoupanca);
            break;
        case 3:
            Console.Write("Digite o número da conta salário: ");
            string numeroContaSalario = Console.ReadLine();
            conta = new ContaSalario(numeroContaSalario);
            break;
        default:
            Console.WriteLine("Opção inválida. Cadastro cancelado.");
            Console.WriteLine();
            return;
    }

    Cliente novoCliente = new Cliente(nome, cpf, conta);
    clientes.Add(novoCliente);

    Console.WriteLine("Cliente cadastrado com sucesso!");
    Console.WriteLine();
}

void ExibirInformacoesConta()
{
    Console.Write("Digite o CPF do cliente: ");
    string cpf = Console.ReadLine();

    Cliente cliente = clientes.Find(c => c.Cpf == cpf);
    if (cliente != null)
    {
        cliente.ExibirInformacoes();
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
        Console.WriteLine();
    }
}

void RealizarDeposito()
{
    Console.Write("Digite o CPF do cliente: ");
    string cpf = Console.ReadLine();

    Cliente cliente = clientes.Find(c => c.Cpf == cpf);
    if (cliente != null)
    {
        Console.Write("Digite o valor do depósito: ");
        double valorDeposito = double.Parse(Console.ReadLine());

        cliente.Depositar(valorDeposito);

        Console.WriteLine("Depósito realizado com sucesso!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
        Console.WriteLine();
    }
}

void RealizarRetirada()
{
    Console.Write("Digite o CPF do cliente: ");
    string cpf = Console.ReadLine();

    Cliente cliente = clientes.Find(c => c.Cpf == cpf);
    if (cliente != null)
    {
        Console.Write("Digite o valor da retirada: ");
        double valorRetirada = double.Parse(Console.ReadLine());

        if (cliente.Saldo >= valorRetirada)
        {
            cliente.Sacar(valorRetirada);
            Console.WriteLine("Retirada realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar a retirada.");
        }

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
        Console.WriteLine();
    }
}
