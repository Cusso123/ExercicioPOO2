using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    class Cliente : IConta
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public double Saldo { get; set; }
        public string Numero { get; set; }

        public Cliente(string nome, string cpf, IConta conta)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Informações da Conta Corrente:");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF:  {Cpf}");
            Console.WriteLine($"Saldo: R${Saldo}");
            Console.WriteLine();
        }

        public double CalcularSaldo() { return Saldo; }

        public void Sacar(double valor) { Saldo -= valor; }
        public void Depositar(double valor) { Saldo += valor; }
    }
}
