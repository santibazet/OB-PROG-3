namespace ObligatorioProgramacion3.Clases_parte_1
{
    public class TipoMaquina
    {
        // Se declaran atributos privados. (Se aplica encapsulamiento correctamente)

        private int idTipoMaquina;
        private string nombreTipo;
        private string descripcion;

        // Se definen las propiedades

        public int IdTipoMaquina
        {
            get { return idTipoMaquina; }
            set { idTipoMaquina = value; }
        }

        public string NombreTipo
        {
            get { return nombreTipo; }
            set { nombreTipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        // Se declara constructor vacio

        public TipoMaquina()
        {
            
        }

        // Se define constructor para crear objetos de tipo TipoMaquina
        public TipoMaquina(int idTipoMaquina, string nombreTipo, string descripcion)
        {
            this.idTipoMaquina = idTipoMaquina;
            this.nombreTipo = nombreTipo;
            this.descripcion = descripcion;
        }

        // Se definen metodos CRUD y otros (incompletos)

        public void CrearTipoMaquina()
        {

        }

        public void DevolverTipoMaquina()
        {

        }

        public void ModificarTipoMaquina()
        {

        }

        public void EliminarTipoMaquina()
        {

        }



        public void ModificarDescripcion()
        {

            Console.WriteLine($"Se ha modificado la descripción del tipo de máquina '{nombreTipo}' a {descripcion}.");
        }

    }
}
