using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    class Corrente : IConta
    {
        public double Saldo { get; set; }
        public string Numero { get; set; }

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

        public double CalcularTarifa()
        {
            return 0;
        }

        public Cliente Cliente { get; set; }

        public decimal Salario { get; set; }


        public Corrente(Cliente cliente, decimal salario = 0)
        {
            Cliente = cliente;
            Salario = salario;
        }

        public Corrente(string? numero)
        {
            Numero = numero;
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