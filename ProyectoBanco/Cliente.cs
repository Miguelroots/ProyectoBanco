using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public int ID { get; set; }

        public Cliente(string nombre, int id)
        {
            Nombre = nombre;
            ID = id;
        }
    }
}
