// See https://aka.ms/new-console-template for more information

using EjercicioHerencia;

string nombre;
int cant;
int caG;
int cantGas;
int canCil250;

Console.WriteLine("------Clase Vehiculos------");
Console.Write("Ingresa el nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingresa datos del vehiculo: ");

Console.Write("Ingresar la cantidad que ingresa al dia: ");
cant = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de vehiculos a gas: ");
caG = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de vehiculos a gasolina: ");
cantGas = int.Parse(Console.ReadLine());
Vehiculos vehiculo1 = new Vehiculos(n: "Tipo de vehiculo", cap: 8, cant: 25, caG: 50, cantGas: 150);

Console.WriteLine("------Clase Moto------");
Console.WriteLine("Ingresa datos de la moto: ");
Console.Write("Ingresar la cantidad que ingresa al dia: ");
cant = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de motos con cilindraje mayor a 250: ");
canCil250 = int.Parse(Console.ReadLine());
Motos moto1 = new Motos(n: "Tipo Moto", cap: 5, cant: 18, cc250: 10);

MedioTransporte medioTrans = new MedioTransporte(nom: "Danny", cap: 15, cant: 20);

medioTrans.mostrarMedioTransporte();
vehiculo1.mostrarVehiculos();
moto1.mostrarMotos();

int cantPer = (vehiculo1.CalPersons(8) + moto1.CalPersons(5));
Console.WriteLine("Cantidad maxima de personas: " + cantPer);
