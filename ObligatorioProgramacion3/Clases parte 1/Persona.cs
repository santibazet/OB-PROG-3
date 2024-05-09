namespace ObligatorioProgramacion3.Clases_parte_1
{
    public abstract class Persona
    {
        // Se declaran atributos privados. (Se aplica encapsulamiento correctamente)

        private int idPersona;
        private string nombre;
        private int telefono;

        // Se definen las propiedades

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        // Constructor vacio

        public Persona()
        {

        }

        // Se define constructor para crear objetos de tipo Persona
        public Persona(int idPersona, string nombre, int telefono)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        // Se definen metodos (incompletos)

        public abstract void CrearPersona();
        public abstract void DevolverPersona();
        public abstract void ModificarPersona();
        public abstract void EliminarPersona();


    }
}
