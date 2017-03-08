namespace Observer.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IObserver
    {
        // Metodo que sera invocado por el Subject
        // El objeto "o" seran los valores que el Subject le pasara al Observer
        void update(object objeto);
    }
}