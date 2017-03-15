namespace Singleton
{
    using System;
    using System.Threading;

    internal class Program
    {
        private static void Main()
        {
            CrearDosInstanciasDeLaClaseSingleton();

            Console.WriteLine("*****************************************************");

            CrearDosInstanciasDeLaClaseSingletonEstatico();

            Console.WriteLine("*****************************************************");

            CrearDosInstanciasDeLaClaseSingletonLock();

            Console.WriteLine("*****************************************************");

            CrearDosInstanciasDeLaClaseSingletonClaseInterna();

            Console.WriteLine("*****************************************************");

            CrearDosInstanciasDeLaClaseSingletonLambda();

            Console.WriteLine("*****************************************************");

            Console.ReadLine();
        }

        /// <summary>
        /// Tratar de crear dos instancias de la clase y verificar que se devuelve la misma instancia.
        /// </summary>
        private static void CrearDosInstanciasDeLaClaseSingleton()
        {
            Singleton singleton = Singleton.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            Singleton segundoSingleton = Singleton.Instance;

            Console.WriteLine("Singleton \n");

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                singleton.Nombre, singleton.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                segundoSingleton.Nombre, segundoSingleton.HoraArranque.ToLongTimeString()));

            Console.WriteLine("---------------");

            //La instancia puede utilizarse como si la instancia siempre hubiese existido:
            //recordemos que si el atributo privado _instancia no tiene valor,
            //el propio getter de la propiedad Instance se encargará de invocar al constructor.
            Console.WriteLine("El singleton se creó a las " + Singleton.Instance.HoraArranque.ToLongTimeString());
        }

        /// <summary>
        /// Tratar de crear dos instancias de la clase y verificar que se devuelve la misma instancia.
        /// </summary>
        private static void CrearDosInstanciasDeLaClaseSingletonEstatico()
        {
            //Primera Instancia del singleton
            SingletonEstatico singleton = SingletonEstatico.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            SingletonEstatico segundoSingleton = SingletonEstatico.Instance;

            Console.WriteLine("Singleton Estático \n");

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                singleton.Nombre, singleton.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                segundoSingleton.Nombre, segundoSingleton.HoraArranque.ToLongTimeString()));

            Console.WriteLine("---------------");

            Console.WriteLine("El singleton Estático se creó a las " + SingletonEstatico.Instance.HoraArranque.ToLongTimeString());
        }

        /// <summary>
        /// Tratar de crear dos instancias de la clase y verificar que se devuelve la misma instancia.
        /// </summary>
        private static void CrearDosInstanciasDeLaClaseSingletonLock()
        {
            //Primera Instancia del singleton
            SingletonLock singleton = SingletonLock.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            SingletonLock segundoSingleton = SingletonLock.Instance;

            Console.WriteLine("Singleton Lock \n");

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                singleton.Nombre, singleton.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                segundoSingleton.Nombre, segundoSingleton.HoraArranque.ToLongTimeString()));

            Console.WriteLine("---------------");

            Console.WriteLine("El singleton Lock se creó a las " + SingletonLock.Instance.HoraArranque.ToLongTimeString());
        }

        /// <summary>
        /// Tratar de crear dos instancias de la clase y verificar que se devuelve la misma instancia.
        /// </summary>
        private static void CrearDosInstanciasDeLaClaseSingletonClaseInterna()
        {
            //Primera Instancia del singleton
            SingletonClaseInterna singleton = SingletonClaseInterna.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            SingletonClaseInterna segundoSingleton = SingletonClaseInterna.Instance;

            Console.WriteLine("Singleton Clase Interna \n");

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                singleton.Nombre, singleton.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                segundoSingleton.Nombre, segundoSingleton.HoraArranque.ToLongTimeString()));

            Console.WriteLine("---------------");

            Console.WriteLine("El singleton clase Interna se creó a las " + SingletonClaseInterna.Instance.HoraArranque.ToLongTimeString());
        }

        /// <summary>
        /// Tratar de crear dos instancias de la clase y verificar que se devuelve la misma instancia.
        /// </summary>
        private static void CrearDosInstanciasDeLaClaseSingletonLambda()
        {
            //Primera Instancia del singleton
            SingletonLambda singleton = SingletonLambda.Instance;

            // Hacemos una pausa de tres segundos
            Thread.Sleep(3000);

            // Intentamos instanciar un segundo Singleton
            SingletonLambda segundoSingleton = SingletonLambda.Instance;

            Console.WriteLine("Singleton Lambda \n");

            // Comprobamos que ambos objetos son referencias a la misma
            // instancia, que es única
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                singleton.Nombre, singleton.HoraArranque.ToLongTimeString()));
            Console.WriteLine(string.Format("Instancia {0} creada a las {1}",
                segundoSingleton.Nombre, segundoSingleton.HoraArranque.ToLongTimeString()));

            Console.WriteLine("---------------");

            Console.WriteLine("El singleton Lambda se creó a las " + SingletonLambda.Instance.HoraArranque.ToLongTimeString());
        }
    }
}