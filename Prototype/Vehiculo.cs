namespace Prototype
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class Vehiculo : ICloneable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Rueda TipoRueda { get; set; }
        public Carroceria TipoCarroceria { get; set; }

        public string VehiculoInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: ").Append(Marca).Append(Environment.NewLine);
            sb.Append("Modelo: ").Append(Modelo).Append(Environment.NewLine);
            sb.Append("Color: ").Append(Color).Append(Environment.NewLine);
            sb.Append("Ruedas: ").Append(TipoRueda.Llanta).Append(" ");
            sb.Append(TipoRueda.Diametro).Append(" ").Append(TipoRueda.Neumatico).Append(Environment.NewLine);
            sb.Append("Carroceria: ").Append(TipoCarroceria.HabitaculoReforzado).Append(" ");
            sb.Append(TipoCarroceria.TipoCarroceria).Append(" ").Append(TipoCarroceria.Material).Append(Environment.NewLine);

            return sb.ToString();
        }

        #region ICloneable Members

        ///// <summary>
        ///// Metodo usado si es una clonacion superficial (solo en el primer nivel)
        ///// </summary>
        ///// <returns></returns>
        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}

        /// <summary>
        /// Metodo usado si se trata de una clonacion profunda, en todos los niveles.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            // Obtenermos una copia superficial del objeto actual
            object copia = this.MemberwiseClone();

            // Recorremos las propiedades del objeto buscando elementos clonables.
            // En caso de encontrar un objeto clonable, realizamos una copia de dicho elemento
            var propiedadesClonables = this.GetType().GetProperties().Where(p => p.PropertyType.GetInterfaces().Contains(typeof(ICloneable)));
            foreach (var propiedad in propiedadesClonables)
            {
                // Obtenemos el nombre de la propiedad (p.e. "TipoRueda")
                var nombrePropiedad = propiedad.Name;

                // Localizamos el método Clone() de la propiedad (TipoRueda.Clone()) y lo
                // invocamos mediante reflection, almacenando el objeto resultante en una variable
                MethodInfo metodoClone = propiedad.PropertyType.GetMethod("Clone");
                var objetoCopia = metodoClone.Invoke(propiedad.GetValue(copia), null);

                // Obtenemos una referencia a la propiedad del objeto clonado (Vehiculo2.TipoRueda)
                PropertyInfo referenciaCopia = this.GetType().GetProperty(nombrePropiedad, BindingFlags.Public | BindingFlags.Instance);

                // Asignamos el valor del objeto clonado a la referencia (Vehiculo2.TipoRueda = Rueda2)
                referenciaCopia.SetValue(copia, objetoCopia, null);
            }

            return copia;
        }

        #endregion ICloneable Members
    }
}