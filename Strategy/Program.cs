namespace Strategy
{
    using Strategy.Implementations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.ConduccionDeportiva();
            vehiculo.Acelerar(2.4f);

            Console.WriteLine("");

            vehiculo.ConduccionNormal();
            vehiculo.Acelerar(2.4f);

            Console.ReadLine();
        }
    }
}