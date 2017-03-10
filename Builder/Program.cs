namespace Builder
{
    using Builder.Implementations;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Definimos un director, pasándole un constructor de Audi como parámetro
            VehiculoDirector directorAudi = new VehiculoDirector(new A3SportbackBuilder());

            // El director construye el vehiculo, delegando en el constructor la tarea de
            // creación de cada una de las piezas
            directorAudi.ConstruirVehiculo();

            // Obtenemos el vehículo directamente del director, aunque la instancia del vehículo
            // se encuentra en el constructor.
            Vehiculo audiA3 = directorAudi.GetVehiculo();

            // Repetimos el proceso con un constructor distinto.
            VehiculoDirector directorCitroen = new VehiculoDirector(new CitroenXsaraBuilder());
            directorCitroen.ConstruirVehiculo();
            Vehiculo citroen = directorCitroen.GetVehiculo();

            // Mostramos por pantalla los dos vehiculos:
            Console.WriteLine("PRIMER VEHICULO:" + Environment.NewLine);
            Console.WriteLine(audiA3.GetPrestaciones());

            Console.WriteLine("SEGUNDO VEHICULO:" + Environment.NewLine);
            Console.WriteLine(citroen.GetPrestaciones());

            Console.ReadLine();
        }
    }
}