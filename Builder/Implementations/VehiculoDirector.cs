namespace Builder.Implementations
{
    using System;

    public class VehiculoDirector
    {
        private VehiculoBuilder builder;

        // Constructor que recibirá un Builder concreto y lo asociará al director
        public VehiculoDirector(VehiculoBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirVehiculo()
        {
            // Construimos el vehiculo definiendo el orden del proceso
            builder.DefinirVehiculo();
            builder.ConstruirHabitaculo();
            builder.ConstruirMotor();
            builder.ConstruirRuedas();
            builder.DefinirExtras();

            // Se realizan comprobaciones y validaciones
            if ((builder.GetVehiculo().TipoCarroceria.TipoCarroceria == "deportivo") &&
                (builder.GetVehiculo().DireccionAsistida == false))
                throw new Exception("Error en el ensamblado: Un deportivo no puede carecer de direccion asistida");
        }

        public Vehiculo GetVehiculo()
        {
            return builder.GetVehiculo();
        }
    }
}