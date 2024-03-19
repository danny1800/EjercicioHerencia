using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class MedioTransporte
    {
        protected string nombre { get; set; }
        protected int Pasajeros { get; set; }
        protected int cant { get; set; }

        public MedioTransporte(string nom, int cap, int cant)
        {
            this.nombre = nom;
            this.Pasajeros = cap;
            this.cant = cant;
        }

        public void setNombre(string nom)
        {
            nombre = nom;
        }

        public string getNombre()
        {
            return nombre;
        }
        public int CalPersons(int personas)
        {
            personas = (Pasajeros * cant);
            return personas;
        }
        public void mostrarMedioTransporte()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Capacidad de pasajeros: " + Pasajeros);
            Console.WriteLine("Cantidad que ingresan al dia: " + cant);
        }
    }
}
