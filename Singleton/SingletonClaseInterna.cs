namespace Singleton
{
    using System;

    public sealed class SingletonClaseInterna
    {
        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        private SingletonClaseInterna()
        {
            Nombre = "Patrón Singleton con clase interna";
            HoraArranque = DateTime.Now;
        }

        // Declaramos una clase interna de carácter privado (sólo accesible desde
        // la clase SingletonClaseInterna)
        private class ClaseInterna
        {
            // Constructor estático
            static ClaseInterna()
            {
            }

            // Declaramos el atributo como internal para que pueda ser accedido
            // por SingletonClaseInterna
            internal static readonly SingletonClaseInterna _instancia = new SingletonClaseInterna();
        }

        // La Property de sólo lectura Instance recuperará la instancia alojada en
        // la clase interna.
        public static SingletonClaseInterna Instance
        {
            get { return ClaseInterna._instancia; }
        }
    }
}