namespace Strategy.Implementations
{
    using Strategy.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Contexto
    {
        // Referencia a la interfaz
        private ITipoConduccion tipoConduccion;

        // Propiedad que establecerá un nuevo tipo de conducción (cambio de estrategia)
        public ITipoConduccion TipoConduccion
        {
            get { return tipoConduccion; }
            set { tipoConduccion = value; }
        }

        // Métodos de servicio (invocan los métodos implementados por las estrategias)
        public string ObtenerDescripcion()
        {
            return tipoConduccion.ObtenerDescripcion();
        }

        public int IncrementarVelocidad(float combustible)
        {
            return tipoConduccion.ObtenerIncrementoVelocidad(combustible);
        }

        public int IncrementarPotencia(float combustible)
        {
            return tipoConduccion.ObtenerPotencia(combustible);
        }
    }
}