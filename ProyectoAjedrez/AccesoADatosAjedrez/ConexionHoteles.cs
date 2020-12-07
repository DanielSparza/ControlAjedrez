using EntidadesAjedrez;
using System.Data;

namespace AccesoADatosAjedrez
{
    public class ConexionHoteles
    {
        ConexionBD c = new ConexionBD();
        public string GuardarHotel(EntidadHoteles h)
        {
            return c.Comando(string.Format("insert into hoteles values(null,'{0}','{1}','{2}')", h.Nombre, h.Direccion, h.Telefono));
        }
        public string Actualizar(EntidadHoteles h)
        {
            return c.Comando(string.Format("update hoteles set Nombre = '{0}', Direccion = '{1}', Telefono = '{2}' where IdHotel = '{3}'",
                h.Nombre, h.Direccion, h.Telefono, h.IdHotel));
        }
        public string Eliminar(EntidadHoteles h)
        {
            return c.Comando(string.Format("Delete from hoteles where idhotel = '{0}'", h.IdHotel));
        }
        public DataSet Mostrar(string nombre)
        {
            return c.Mostrar(string.Format("select * from hoteles where nombre like '%{0}%'", nombre), "hoteles");
        }
    }
}
