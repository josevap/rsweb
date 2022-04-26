namespace RSWEB_Proekt.Models
{
    public class PredmetProfesor
    {
        public int Id { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
    }
}
