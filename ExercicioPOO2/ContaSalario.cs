using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    class ContaSalario : IConta
    {
        private string? numeroContaSalario;

        public ContaSalario(string? numeroContaSalario)
        {
            this.numeroContaSalario = numeroContaSalario;
        }

        public double Saldo { get; set; }
        public string Numero { get; set; }

        public double CalcularSaldo() { return Saldo; }
        public void Sacar(double valor) { Saldo -= valor; }
        public void Depositar(double valor) { Saldo += valor; }
    }
}
