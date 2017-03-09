namespace Strategy.Implementations
{
    using Strategy.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConduccionDeportiva : ITipoConduccion
    {
        public string ObtenerDescripcion()
        {
            return "Conduccion Deportiva";
        }

        public int ObtenerPotencia(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.987) + 5;
        }

        public int ObtenerIncrementoVelocidad(float decilitrosCombustible)
        {
            return (int)(decilitrosCombustible * 0.618) + 3;
        }
    }
}