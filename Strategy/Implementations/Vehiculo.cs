namespace Strategy.Implementations
{
    using Strategy.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Vehiculo
    {
        private Contexto contexto;

        public Vehiculo()
        {
            contexto = new Contexto();
        }

        public void ConduccionDeportiva()
        {
            ITipoConduccion conduccionDeportiva = new ConduccionDeportiva();
            contexto.TipoConduccion = conduccionDeportiva;
        }

        public void ConduccionNormal()
        {
            ITipoConduccion conduccionNormal = new ConduccionNormal();
            contexto.TipoConduccion = conduccionNormal;
        }

        // Métodos que invocan la funcionalidad implementada por la interfaz
        public void Acelerar(float combustible)
        {
            string descripcion = contexto.ObtenerDescripcion();
            int incrementoVelocidad = contexto.IncrementarVelocidad(combustible);
            int potencia = contexto.IncrementarPotencia(combustible);

            Console.WriteLine("Tipo de conducción " + descripcion);
            Console.WriteLine("Combustible inyectado: " + combustible);
            Console.WriteLine("Potencia proporcionada: " + potencia);
            Console.WriteLine("Incremento de velocidad: " + incrementoVelocidad);
        }
    }
}