using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class CuentaBancaria
    {
        public int ID { get; set; }
        public double Saldo { get; set; }
        public Cliente Propietario { get; set; }

        public CuentaBancaria(int id, double saldo, Cliente propietario)
        {
            ID = id;
            Saldo = saldo;
            Propietario = propietario;
        }

        public void Depositar(double cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine($"El cliente {Propietario.Nombre} ha depositado {cantidad} en la cuenta {ID}");
        }

        public void Retirar(double cantidad)
        {
            if (Saldo - cantidad >= 0)
            {
                Saldo -= cantidad;
                Console.WriteLine($"El cliente {Propietario.Nombre} ha retirado {cantidad} de la cuenta {ID}");
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo en la cuenta para realizar la operación");
            }
        }
    }
}
