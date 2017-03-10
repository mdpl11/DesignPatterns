namespace Observer.Interfaces
{
    // Interfaz que expone los metodos de registro y eliminacion de observers, asi como para
    // la notificacion de los cambios de estado.
    public interface ISubject
    {
        void RegistrarObserver(IObserver objeto);

        void EliminarObserver(IObserver objeto);

        void NotificarObservers();
    }
}