using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    interface IConta
    {
        double Saldo { get; set; }
        string Numero { get; set; }

        double CalcularSaldo();
        void Sacar(double valor);
        void Depositar(double valor);
    }
}
