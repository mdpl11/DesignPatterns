namespace Observer
{
    using Implementations;
    using Interfaces;
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creamos un medidor de sensores
            ISubject sensores = new MedidorSensores(20, 380, 200);

            // Creamos dos observers: un display y un emisor de alertas.
            // Se realiza la suscripcion a traves del constructor
            IObserver display = new ObserverDisplay(sensores);
            IObserver alerta = new ObserverAlerta(sensores);

            // Modificamos valores del subject. Los observers son automaticamente informados
            // y actuaran automaticamente
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelPresionNeumaticos -= 50;

            // Eliminamos el registro de las alertas y aumentamos los niveles para comprobar que no
            // son informados
            //sensores.EliminarObserver(alerta);

            ((MedidorSensores)sensores).NivelAceite += 10;
            ((MedidorSensores)sensores).NivelAgua += 100;
            ((MedidorSensores)sensores).NivelAgua += 100;

            Console.ReadLine();
        }
    }
}