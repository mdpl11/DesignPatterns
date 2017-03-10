namespace Builder.Implementations
{
    using Builder.Interfaces;
    using System;
    using System.Text;

    public class Vehiculo
    {
        public bool CierreCentralizado { get; set; }
        public string Color { get; set; }
        public bool DireccionAsistida { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public IMotor Motor { get; set; }
        public Carroceria TipoCarroceria { get; set; }
        public Rueda TipoRuedas { get; set; }

        public string GetPrestaciones()
        {
            StringBuilder sb = new StringBuilder();
            string nl = Environment.NewLine;

            sb.Append("El presente vehiculo es un ").Append(Marca).Append(" ").Append(Modelo);
            sb.Append(" estilo ").Append(TipoCarroceria.TipoCarroceria).Append(nl);
            sb.Append("Color: ").Append(Color).Append(nl);
            sb.Append(DireccionAsistida ? "Con " : "Sin ").Append("direccion asistida").Append(nl);
            sb.Append(CierreCentralizado ? "Con " : "Sin ").Append("cierre centralizado").Append(nl);
            sb.Append("Carroceria de ").Append(TipoCarroceria.Material);
            sb.Append(TipoCarroceria.HabitaculoReforzado ? " con " : " sin ").Append("el habitaculo reforzado").Append(nl);
            sb.Append("Ruedas con llantas ").Append(TipoRuedas.Llanta).Append(" de ").Append(TipoRuedas.Diametro).Append(" cm").Append(nl);
            sb.Append("Neumaticos ").Append(TipoRuedas.Neumatico);
            sb.Append("Respuesta del motor: ").Append(Motor.InyectarCombustible(100));

            return sb.ToString();
        }
    }
}