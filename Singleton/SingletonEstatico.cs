using System;

namespace Singleton
{
    /// <summary>
    /// este singleton es mas que suficiente para la mayoría de las ocasiones: es simple, rápido y seguro.
    /// Sin embargo, deja un fleco suelto: no permite realizar ninguna operación de pre-configuración antes de realizar
    /// el instanciado del Singleton, ya que la generación de la instancia se produce automáticamente por parte del CLR
    /// y no es posible codificar nada antes de que esto ocurra. Para esto se puede usar el Singleton multihilo nativo (SingletonLock.cs)
    /// </summary>
    public sealed class SingletonEstatico
    {
        // El atributo _instancia es read-only, por lo que únicamente podrá ser instanciado
        // una sola vez (la primera vez que la clase sea accedida).
        //Esta forma de instanciar objetos se conoce por el nombre de Lazy Instantiation o Instanciación diferida.
        private static readonly SingletonEstatico _instancia = new SingletonEstatico();

        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        private SingletonEstatico()
        {
            Nombre = "Patrón Singleton Estático";
            HoraArranque = DateTime.Now;
        }

        public static SingletonEstatico Instance
        {
            get { return _instancia; }
        }
    }
}