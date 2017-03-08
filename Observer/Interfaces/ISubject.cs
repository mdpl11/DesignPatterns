namespace Observer.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // Interfaz que expone los metodos de registro y eliminacion de observers, asi como para
    // la notificacion de los cambios de estado.
    public interface ISubject
    {
        void RegistrarObserver(IObserver objeto);

        void EliminarObserver(IObserver objeto);

        void NotificarObservers();
    }
}