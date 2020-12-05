namespace EntidadesAjedrez
{
    public class EntidadReservacion
    {
        public int IdReservacion { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaSalida { get; set; }
        public int FkIdHotel { get; set; }
        public string FkIdPersona { get; set; }

        public EntidadReservacion(int idreservacion, string fechaentrada, string fechasalida, int fkidhotel, string fkidpersona)
        {
            IdReservacion = idreservacion;
            FechaEntrada = fechaentrada;
            FechaSalida = fechasalida;
            FkIdHotel = fkidhotel;
            FkIdPersona = fkidpersona;

        }
    }
}
