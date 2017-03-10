using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo();

            v.Marca = "Peugeot";
            v.Modelo = "306";
            v.Color = "Negro";

            v.TipoCarroceria = new Carroceria();
            v.TipoCarroceria.Material = "Acero";
            v.TipoCarroceria.HabitaculoReforzado = true;
            v.TipoCarroceria.TipoCarroceria = "Monovolumen";

            v.TipoRueda = new Rueda();
            v.TipoRueda.Neumatico = "Bridgestone";
            v.TipoRueda.Llanta = "Aluminio";
            v.TipoRueda.Diametro = 17;

            Vehiculo v2 = v.Clone() as Vehiculo;

            v2.Color = "Rojo";
            v2.TipoRueda.Diametro = 15;
            v2.TipoRueda.Neumatico = "Michelin";
            v2.TipoRueda.Llanta = "Aleación";

            Console.WriteLine(v.VehiculoInfo());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(v2.VehiculoInfo());

            Console.ReadLine();
        }
    }
}