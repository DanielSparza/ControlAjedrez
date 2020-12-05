namespace EntidadesAjedrez
{
    public class EntidadSalas
    {
        public int IdSala { get; set; }
        public int Capacidad { get; set; }
        public string Medios { get; set; }
        public int FkIdHotel { get; set; }

        public EntidadSalas(int idsala, int capacidad, string medios, int fkidhotel)
        {
            IdSala = idsala;
            Capacidad = capacidad;
            Medios = medios;
            FkIdHotel = fkidhotel;
        }
    }
}
