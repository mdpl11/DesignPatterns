namespace Builder.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class VehiculoBuilder
    {
        // Declaramos la referencia del producto a construir
        protected Vehiculo vehiculo;

        // Declaramos el método que recuperará el objeto
        public Vehiculo GetVehiculo()
        {
            return vehiculo;
        }

        #region Métodos Abstractos

        public abstract void DefinirVehiculo();

        public abstract void ConstruirRuedas();

        public abstract void ConstruirHabitaculo();

        public abstract void ConstruirMotor();

        public abstract void DefinirExtras();

        #endregion Métodos Abstractos
    }
}