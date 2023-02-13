using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cliente cliente1 = new Cliente("Juan", 1);
            Cliente cliente2 = new Cliente("Pedro", 2);
            Cliente cliente3 = new Cliente("Ana", 3);

            CuentaBancaria cuenta1 = new CuentaBancaria(1, 1000, cliente1);
            CuentaBancaria cuenta2 = new CuentaBancaria(2, 2000, cliente2);
            CuentaBancaria cuenta3 = new CuentaBancaria(3, 3000, cliente3);

            Banco banco = new Banco(new CuentaBancaria[] { cuenta1, cuenta2, cuenta3 });

            cuenta1.Depositar(500);
            cuenta2.Retirar(500);

            banco.CalcularTotalDepositado();

            Console.ReadLine();
        }
    }
}
