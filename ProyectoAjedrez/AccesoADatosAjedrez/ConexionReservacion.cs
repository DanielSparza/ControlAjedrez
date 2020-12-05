using System.Data;
using EntidadesAjedrez;

namespace AccesoADatosAjedrez
{
    public class ConexionReservacion
    {
        ConexionBD c = new ConexionBD();
        public string GuardarReservacion(EntidadReservacion r)
        {
            return c.Comando(string.Format("insert into hospedaje values(null,'{0}','{1}','{2}','{3}')", r.FechaEntrada, r.FechaSalida, r.FkIdHotel, r.FkIdPersona));
        }

        public string ActualizarReservacion(EntidadReservacion r)
        {
            return c.Comando(string.Format("update hospedaje set FechaEntrada = '{0}', FechaSalida = '{1}', FkHotel = '{2}', FkPersona = '{3}' where IdReserva = '{4}'",
                r.FechaEntrada, r.FechaSalida, r.FkIdHotel, r.FkIdPersona, r.IdReservacion));
        }
        public string EliminarReservacion(EntidadReservacion r)
        {
            return c.Comando(string.Format("delete from hospedaje where idreserva = '{0}'", r.IdReservacion));
        }
        public DataSet MostrarReservacion(string nombre)
        {
            return c.Mostrar(string.Format("select r.idreserva, r.fechaentrada, r.fechasalida, h.nombre as 'NombreHotel', p.nombre, p.apaterno, p.amaterno from hospedaje r, hotel h, personas p where r.fkhotel = h.idhotel and r.fkpersona = p.idpersona and p.nombre like '%{0}%'", nombre), "hospedaje");
        }
        public DataSet MostrarPersonas(string idpersona)
        {
            return c.Mostrar(string.Format("select p.idpersona, p.nombre, p.apaterno, p.amaterno, p.direccion, p.telefono, pa.Nombre as 'Pais' from personas p, pais pa where p.fkpais = pa.idpais and p.idpersona like '%{0}%'", idpersona), "personas");
        }
        public DataSet ObteneridPersona(string nombre, string ap, string am)
        {
            return c.Mostrar(string.Format("select idpersona from personas where nombre = '{0}' and apaterno = '{1}' and amaterno = '{2}'", nombre, ap, am), "Personas");
        }
    }
}
