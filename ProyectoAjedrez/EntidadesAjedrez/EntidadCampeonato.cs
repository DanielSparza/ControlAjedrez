namespace EntidadesAjedrez
{
    public class EntidadCampeonato
    {
        public string FkPersona { get; set; }
        public int IdCampeonato { get; set; }
        public string NombreCampeonato { get; set; }
        public string Tipo { get; set; }

        public EntidadCampeonato(string fkpersona, int idcampeonato, string nombrecampeonato, string tipo)
        {
            FkPersona = fkpersona;
            IdCampeonato = idcampeonato;
            NombreCampeonato = nombrecampeonato;
            Tipo = tipo;
        }
    }
}
