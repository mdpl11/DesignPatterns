namespace Observer.Implementations
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ObserverAlerta : IObserver
    {
        #region Constantes

        // Niveles minimos y maximos
        private static readonly int MIN_ACEITE = 12;

        private static readonly int MAX_ACEITE = 45;

        private static readonly int MIN_AGUA = 300;
        private static readonly int MAX_AGUA = 550;

        private static readonly int MIN_PRESION = 120;
        private static readonly int MAX_PRESION = 350;

        #endregion Constantes

        #region Atributos

        // Atributos que modelan el estado
        private int nivelAceite;

        private int nivelAgua;
        private int nivelPresionNeumaticos;

        // Subject al que se encuentra suscrito el observer
        private ISubject subject;

        #endregion Atributos

        #region Constructores

        // El constructor suscribira el observer al subject
        public ObserverAlerta(ISubject subject)
        {
            this.subject = subject;
            subject.RegistrarObserver(this);
        }

        #endregion Constructores

        #region Metodos de IObserver

        public void update(object o)
        {
            // Comprobamos el tipo del objeto recibido como parametro
            int[] arrayInt = null;
            if (o.GetType().Equals(typeof(int[])))
                arrayInt = (int[])o;

            // Si es del tipo esperado (int[]) y del tamano esperado (3), actualizamos los
            // atributos
            if ((arrayInt != null) && (arrayInt.Length == 3))
            {
                nivelAceite = arrayInt[0];
                nivelAgua = arrayInt[1];
                nivelPresionNeumaticos = arrayInt[2];

                // Comprobamos que los valores no exceden los limites
                ComprobarAceite();
                ComprobarAgua();
                ComprobarNeumaticos();
            }
        }

        #endregion Metodos de IObserver

        // Metodo que comprueba los niveles de aceite
        private void ComprobarAceite()
        {
            if (nivelAceite < MIN_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE ACEITE DEMASIADO BAJO: {0}/{1}", nivelAceite, MIN_ACEITE));
            }
            if (nivelAceite > MAX_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE ACEITE DEMASIADO ALTO: {0}/{1}", nivelAceite, MAX_ACEITE));
            }
        }

        // Metodo que comprueba los niveles de agua
        private void ComprobarAgua()
        {
            if (nivelAgua < MIN_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE AGUA DEMASIADO BAJO: {0}/{1}", nivelAgua, MIN_AGUA));
            }
            if (nivelAgua > MAX_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE AGUA DEMASIADO ALTO: {0}/{1}", nivelAgua, MAX_AGUA));
            }
        }

        // Metodo que comprueba la presion de los neumaticos
        private void ComprobarNeumaticos()
        {
            if (nivelPresionNeumaticos < MIN_PRESION)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE PRESION DE NEUMATICOS DEMASIADO BAJO: {0}/{1}", nivelPresionNeumaticos, MIN_PRESION));
            }
            if (nivelPresionNeumaticos > MAX_PRESION)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE PRESION DE NEUMATICOS DEMASIADO ALTO: {0}/{1}", nivelPresionNeumaticos, MAX_PRESION));
            }
        }

        // Metodo que envie la alerta
        private void EnviarAlerta()
        {
            // Este metodo podria enviar una alerta a la centralita del vehiculo que, por ejemplo,
            // forzaria a su detencion
            Console.WriteLine("Pilas Pilas!!");
        }
    }
}