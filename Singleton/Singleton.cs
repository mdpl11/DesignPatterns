namespace Singleton
{
    using System;

    /// <summary>
    /// NOTA: Este tipo de singleton no es seguro en entornos multi-hilo.
    /// Si dos hilos de ejecución entran en la propiedad Instance al mismo tiempo,
    /// es posible que se creen dos instancias de nuestra clase Singleton.
    /// Para esto se puede usar el Singleton Estático (SingletonEstatico.cs)
    /// </summary>
    public class Singleton
    {
        // Declaramos un atributo del mismo tipo de la clase con carácter estático
        private static Singleton _instancia = null;

        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        // Constructor privado. Únicamente puede ser invocado desde el interior
        // de la propia clase
        private Singleton()
        {
            Nombre = "Patrón Singleton";
            HoraArranque = DateTime.Now;
        }

        // Propiedad de solo lectura
        public static Singleton Instance
        {
            get
            {
                // Si el singleton no ha sido creado previamente, se instancia.
                // En caso contrario, se devolverá el que haya sido creado previamente
                if (_instancia == null)
                    _instancia = new Singleton();

                // Se devuelve la instancia
                return _instancia;
            }
        }
    }
}