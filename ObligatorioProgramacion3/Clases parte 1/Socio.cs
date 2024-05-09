namespace ObligatorioProgramacion3.Clases_parte_1
{
    public abstract class Socio : Persona
    {
        // Se declaran atributos privados. (Se aplica encapsulamiento correctamente)

        private int idSocio;
        private string tipo;
        private string mail;
        private int idLocal;

        // Se definen las propiedades

        public int IdSocio
        {
            get { return idSocio; }
            set { idSocio = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public int IdLocal
        {
            get { return idLocal; }
            set { idLocal = value; }
        }


        // Se declara constructor vacio

        public Socio()
        {
            
        }

        // Se define constructor para crear objetos de tipo Socio

        public Socio(int idSocio, string tipo, string mail, int idLocal)
        {
            this.idSocio = idSocio;
            this.tipo = tipo;
            this.mail = mail;
            this.idLocal = idLocal;
        }

        // Se declaran metodos sobreseescritos de la clase persona y se crean otros necesarios (incompletos)

        public override void CrearPersona() 
        {
        
        }
        public override void DevolverPersona()
        {

        }
        public override void ModificarPersona()
        {

        }
        public override void EliminarPersona()
        {

        }


        public void CalificarRutina()
        {

        }

    }
}
