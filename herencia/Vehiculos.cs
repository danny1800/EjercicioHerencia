using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Vehiculos : MedioTransporte
    {
        private double cantGas { get; set; }
        private double cantiGasolina { get; set; }
        public Vehiculos(string n, int cap, int cant, double caG, double cantGas) : base(n, cap, cant)
        {
            this.cantGas = caG;
            this.cantiGasolina = cantGas;
        }

        public void mostrarVehiculos()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Cantidad de vehiculos a gas: " + cantGas);
            Console.WriteLine("Cantidad de vehiculos a gasolina: " + cantiGasolina);
        }
    }
}
