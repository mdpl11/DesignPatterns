namespace Observer.Implementations
{
    using Interfaces;
    using System.Collections;

    public class MedidorSensores : ISubject
    {
        #region Estado

        // Atributos que modelan el estado
        private int nivelAceite;

        private int nivelAgua;
        private int nivelPresionNeumaticos;

        #endregion Estado

        // Listado de observers
        private IList suscriptores;

        // Constructor que creara un medidor con los valores iniciales de las presiones
        public MedidorSensores(int nivelAceite, int nivelAgua, int nivelPresionNeumaticos)
        {
            this.suscriptores = new ArrayList();
            this.nivelAceite = nivelAceite;
            this.nivelAgua = nivelAgua;
            this.nivelPresionNeumaticos = nivelPresionNeumaticos;
        }

        #region Properties

        public int NivelAceite
        {
            get { return this.nivelAceite; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelAceite != value)
                {
                    this.nivelAceite = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelAgua
        {
            get { return this.nivelAgua; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelAgua != value)
                {
                    this.nivelAgua = value;
                    NotificarObservers();
                }
            }
        }

        public int NivelPresionNeumaticos
        {
            get { return this.nivelPresionNeumaticos; }

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (this.nivelPresionNeumaticos != value)
                {
                    this.nivelPresionNeumaticos = value;
                    NotificarObservers();
                }
            }
        }

        #endregion Properties

        #region ISubject

        // Comprobamos si el observer se encuentra en la lista. En caso contrario,
        // lo incluye en la lista
        public void RegistrarObserver(IObserver observer)
        {
            if (!suscriptores.Contains(observer))
                suscriptores.Add(observer);
        }

        // Comprobamos si el observer se encuentra en la lista. En caso afirmativo,
        // lo elimina de la lista
        public void EliminarObserver(IObserver observer)
        {
            if (suscriptores.Contains(observer))
                suscriptores.Remove(observer);
        }

        // Recorre la lista de observers e invoca su metodo Update()
        public void NotificarObservers()
        {
            // Creamos un array con el estado del Subject
            int[] valores = { this.nivelAceite, this.nivelAgua, this.nivelPresionNeumaticos };

            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (object objeto in suscriptores)
            {
                // Invocamos el metodo Update de cada observer, pasandole el array con el estado
                // del subject como parametro.
                // Cada observer ya hara lo que estime necesario con esa informacion.
                observer = (IObserver)objeto;
                observer.update(valores);
            }
        }

        #endregion ISubject
    }
}