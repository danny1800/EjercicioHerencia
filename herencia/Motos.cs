using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Motos:MedioTransporte
    {
        private int canCil250 { get; set; }
        public Motos(string n, int cap, int cant, int cc250):base(n, cap, cant)
        {
            this.canCil250 = cc250;
        }

        public void mostrarMotos()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Cantidad de motos con cilindraje mayor a 250: " + canCil250);
        }
    }
}
