using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Interfaces
{
    public interface IMotor
    {
        string ConsumirCombustible();

        string InyectarCombustible(int cantidad);

        string RealizarEscape();

        string RealizarExpansion();
    }
}