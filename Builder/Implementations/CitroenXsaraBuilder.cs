namespace Builder.Implementations
{
    public class CitroenXsaraBuilder : VehiculoBuilder
    {
        public override void DefinirVehiculo()
        {
            vehiculo = new Vehiculo();
            vehiculo.Marca = "Citroen";
            vehiculo.Modelo = "Xsara Picasso";
        }

        // Método que construirá las ruedas
        public override void ConstruirRuedas()
        {
            vehiculo.TipoRuedas = new Rueda();
            vehiculo.TipoRuedas.Diametro = 15;
            vehiculo.TipoRuedas.Llanta = "hierro";
            vehiculo.TipoRuedas.Neumatico = "Firestone";
        }

        public override void ConstruirMotor()
        {
            vehiculo.Motor = new MotorDiesel();
        }

        // Método que construirá el habitaculo
        public override void ConstruirHabitaculo()
        {
            vehiculo.TipoCarroceria = new Carroceria();
            vehiculo.TipoCarroceria.TipoCarroceria = "monovolumen";
            vehiculo.TipoCarroceria.HabitaculoReforzado = false;
            vehiculo.TipoCarroceria.Material = "acero";
            vehiculo.Color = "negro";
        }

        public override void DefinirExtras()
        {
            vehiculo.CierreCentralizado = false;
            vehiculo.DireccionAsistida = false;
        }
    }
}