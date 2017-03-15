namespace Singleton
{
    using System;

    public sealed class SingletonLambda
    {
        // Usamos el tipo Lazy<T> para generar la instancia de forma diferida
        private static readonly Lazy<SingletonLambda> _instancia = new Lazy<SingletonLambda>(() => new SingletonLambda());

        public string Nombre { get; set; }
        public DateTime HoraArranque { get; set; }

        private SingletonLambda()
        {
            Nombre = "Patrón Singleton con Lazy<T> y expresión Lambda";
            HoraArranque = DateTime.Now;
        }

        // Accedemos a la propiedad Value de Lazy<SingletonLambda>, provocando su
        // instanciado en el momento de su primer acceso.
        public static SingletonLambda Instance
        {
            get { return _instancia.Value; }
        }
    }
}