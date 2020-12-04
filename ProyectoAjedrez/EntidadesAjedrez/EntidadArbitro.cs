namespace EntidadesAjedrez
{
    public class EntidadArbitro
    {
        public string IdArbitro { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int FkPais { get; set; }

        public EntidadArbitro(string idarbitro, string nombre, string apaterno, string amaterno, string direccion, string telefono, int fkpais)
        {
            IdArbitro = idarbitro;
            Nombre = nombre;
            ApPaterno = apaterno;
            ApMaterno = amaterno;
            Direccion = direccion;
            Telefono = telefono;
            FkPais = fkpais;
        }
    }
}
