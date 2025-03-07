namespace Practicasconmigraciones.AppMVCCodeFirst.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Código { get; set; }
        public string Dirección { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public short YearEstudio { get; set; }
    }
}
