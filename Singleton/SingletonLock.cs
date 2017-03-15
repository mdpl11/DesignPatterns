namespace Singleton
{
    using System;

    public sealed class SingletonLock
    {
        // El Singleton será declarado como volatile para evitar las optimizations del
        // compilador que pueden provocar problemas de concurrencia
        private static volatile SingletonLock _instancia;

        // Instanciamos un nuevo objeto para realizar el bloqueo
        private static object padLock = new Object();

        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        private SingletonLock()
        {
            Nombre = "Patrón Singleton con bloqueo";
            HoraArranque = DateTime.Now;
        }

        public static SingletonLock Instance
        {
            get
            {
                if (_instancia == null)
                {
                    // Realizamos el bloqueo
                    lock (padLock)
                    {
                        // Volvemos a realizar la comprobación
                        if (_instancia == null)
                        {
                            // Aquí podríamos realizar opciones de pre-configuración
                            // antes de instanciar el Singleton, resolviendo el problema
                            // de la inicialización estática
                            _instancia = new SingletonLock();
                        }
                    }
                }

                return _instancia;
            }
        }
    }
}