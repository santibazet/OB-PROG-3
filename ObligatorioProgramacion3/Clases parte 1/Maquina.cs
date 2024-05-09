namespace ObligatorioProgramacion3.Clases_parte_1
{
    public class Maquina
    {

        // Se declaran atributos privados. (Se aplica encapsulamiento correctamente)

        private int idMaquina;
        private int idLocal;
        private DateTime fechaCompra;
        private int precioCompra;
        private int vidaUtil;
        private int idTipoMaquina;
        private bool disponible;


        // Se definen las propiedades

        public int IdMaquina
        {
            get { return idMaquina; }
            set { idMaquina = value; }
        }

        public int IdLocal 
        {
            get { return idLocal; }
            set { idLocal = value; }
        }

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
        }

        public int PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }

        public int VidaUtil
        {
            get { return vidaUtil; }
            set { vidaUtil = value; }
        }

        public int IdTipoMaquina
        {
            get { return idTipoMaquina; }
            set { idTipoMaquina = value; }
        }

        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }


        // Se declara constructor vacio

        public Maquina()
        {

        }

        // Se define constructor para crear objetos de tipo Maquina

        public Maquina(int idMaquina, int idLocal ,DateTime fechaCompra, int precioCompra, int vidaUtil, int idTipoMaquina, bool disponible)
        {
            this.idMaquina = idMaquina;
            this.idLocal = idLocal;
            this.fechaCompra = fechaCompra;
            this.precioCompra = precioCompra;
            this.vidaUtil = vidaUtil;
            this.idTipoMaquina = idTipoMaquina;
            this.disponible = disponible;
        }

        // Se definen metodos CRUD y otros (obviamente incompletos)


        public void CrearMaquina()
        {

        }

        public void DevolverMaquina()
        {

        }

        public void ModificarMaquina()
        {

        }

        public void EliminarMaquina()
        {

        }



        public void MostrarVidaUtilActual()
        {
            Console.WriteLine($"Vida útil actual de la máquina {idMaquina} es de: {vidaUtil} años");
        }

        public void CambiarNoDisponible()
        {
            disponible = false;
            Console.WriteLine($"Ahora, la máquina {idMaquina} ya no se encuentra disponible.");
        }

        public void CambiarDisponible()
        {
            disponible = true;
            Console.WriteLine($"Ahora, la máquina {idMaquina} se encuentra disponible.");
        }

        public int CalcularVidaUtilRestante()
        {
            return VidaUtil - (DateTime.Now.Year - FechaCompra.Year);
        }
    }
}
