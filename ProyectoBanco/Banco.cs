using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class Banco
    {
        public CuentaBancaria[] Cuentas { get; set; }

        public Banco(CuentaBancaria[] cuentas)
        {
            Cuentas = cuentas;
        }

        public void CalcularTotalDepositado()
        {
            double total = 0;
            foreach (CuentaBancaria cuenta in Cuentas)
            {
                total += cuenta.Saldo;
            }

            Console.WriteLine($"El total depositado en el banco es de {total}");
        }
    }
}
