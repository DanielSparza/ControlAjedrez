using System.Data;
using EntidadesAjedrez;

namespace AccesoADatosAjedrez
{
    public class ConexionSalas
    {
        ConexionBD c = new ConexionBD();
        public string GuardarSala(EntidadSalas s)
        {
            return c.Comando(string.Format("insert into salas values(null,'{0}','{1}','{2}')", s.Capacidad, s.Medios, s.FkIdHotel));
        }
        public string ActualizarSala(EntidadSalas s)
        {
            return c.Comando(string.Format("update salas set capacidad = '{0}', medios = '{1}', fkhotel = '{2}' where idsala = '{3}'",
                s.Capacidad, s.Medios, s.FkIdHotel, s.IdSala));
        }
        public string EliminarSala(EntidadSalas s)
        {
            return c.Comando(string.Format("delete from salas where idsala = '{0}'", s.IdSala));
        }
        public DataSet Mostrar(string nombre)
        {
            return c.Mostrar(string.Format("select s.idsala, s.capacidad, s.medios,h.nombre as NombreHotel from salas s, hoteles h where h.idhotel = s.fkhotel and h.nombre like '%{0}%'", nombre), "Sala");
        }
        public DataSet ObtenerHotel()
        {
            return c.Mostrar("select nombre from hoteles", "hoteles");
        }
        public DataSet ObtenerIdHotel(string nombre)
        {
            return c.Mostrar(string.Format("select idhotel from hoteles where nombre = '{0}' ", nombre), "hoteles");
        }
    }
}
