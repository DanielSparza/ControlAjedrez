namespace EntidadesAjedrez
{
    public class EntidadHoteles
    {
        public int IdHotel { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public EntidadHoteles(int idhotel, string nombre, string direccion, string telefono)
        {
            IdHotel = idhotel;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
