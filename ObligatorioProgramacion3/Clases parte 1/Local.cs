using System.Runtime.CompilerServices;

namespace ObligatorioProgramacion3.Clases_parte_1
{
    public class Local
    {

        // Se declaran atributos privados. (Se aplica encapsulamiento correctamente)

        private int idLocal;
        private string? nombre;
        private string? ciudad;
        private string? direccion;
        private int telefono;
        private Persona responsable;


        // Se definen las propiedades

        public int IdLocal 
        {
            get {return idLocal; } 
            set {idLocal = value; } 
        }

        public string? Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string? Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public string? Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Persona IdResponsable
        {
            get { return responsable; }
            set { responsable = value; }
        }


        // Se declara constructor vacio

        public Local()
        {
            
        }

        // Se define constructor para crear objetos de tipo Local

        public Local(int idLocal, string? nombre, string? ciudad, string? direccion, int telefono, Persona responsable)
        {
            this.idLocal = idLocal;
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.telefono = telefono;
            this.responsable = responsable;
        }


        // Declaracion de metodos

        public void CrearLocal()
        {

        }

        public void DevolverLocal()
        {

        }

        public void ModificarLocal()
        {

        }

        public void EliminarLocal()
        {

        }




        public void MostrarTiposMaquina()
        {

        }

        public void VincularResponLocal()
        {

        }

        public void DesvincularResponLugar()
        {

        }


    }
}
