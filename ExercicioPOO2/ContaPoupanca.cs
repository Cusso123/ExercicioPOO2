using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    class Poupanca : IConta
    {
        public Poupanca(string numero)
        {
            Numero = numero;
        }
        public string Numero { get; set; }
        public double Saldo { get; set; }

        public double CalcularSaldo()
        {
            return Saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Cliente(string nome, string cpf)
        {
            Console.WriteLine("Digite o nome do cliente");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF");
            cpf = Console.ReadLine();
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações da Conta Corrente:");
            Console.WriteLine($"Número da Conta: {Numero}");
            Console.WriteLine($"Saldo: R${Saldo}");
            Console.WriteLine();
        }
    }
}
