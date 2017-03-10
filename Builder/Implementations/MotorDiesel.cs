namespace Builder.Implementations
{
    using Builder.Interfaces;

    public class MotorDiesel : IMotor
    {
        #region IMotor Members

        public string ConsumirCombustible()
        {
            return RealizarCombustion();
        }

        public string InyectarCombustible(int cantidad)
        {
            return string.Format("MotorDiesel: Inyectados {0} ml. de Gasoil.", cantidad);
        }

        public string RealizarEscape()
        {
            return "MotorDiesel: Realizado escape de gases";
        }

        public string RealizarExpansion()
        {
            return "MotorDiesel: Realizada expansion";
        }

        #endregion IMotor Members

        private string RealizarCombustion()
        {
            return "MotorDiesel: Realizada combustion del Gasoil";
        }
    }
}