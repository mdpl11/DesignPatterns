namespace Builder.Implementations
{
    public class A3SportbackBuilder : VehiculoBuilder
    {
        public override void DefinirVehiculo()
        {
            vehiculo = new Vehiculo();
            vehiculo.Marca = "Audi";
            vehiculo.Modelo = "A3 Sportback";
        }

        // Método que construirá las ruedas
        public override void ConstruirRuedas()
        {
            vehiculo.TipoRuedas = new Rueda();
            vehiculo.TipoRuedas.Diametro = 17;
            vehiculo.TipoRuedas.Llanta = "aluminio";
            vehiculo.TipoRuedas.Neumatico = "Michelin";
        }

        // Método que construirá el motor
        public override void ConstruirMotor()
        {
            vehiculo.Motor = new MotorDiesel();
        }

        // Método que construirá el habitaculo
        public override void ConstruirHabitaculo()
        {
            vehiculo.TipoCarroceria = new Carroceria();
            vehiculo.TipoCarroceria.TipoCarroceria = "deportivo";
            vehiculo.TipoCarroceria.HabitaculoReforzado = true;
            vehiculo.TipoCarroceria.Material = "fibra de carbono";
            vehiculo.Color = "plata cromado";
        }

        public override void DefinirExtras()
        {
            vehiculo.CierreCentralizado = true;
            vehiculo.DireccionAsistida = true;
        }
    }
}