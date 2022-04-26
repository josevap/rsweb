using System.ComponentModel.DataAnnotations;

namespace RSWEB_Proekt.Models
{
    public class Predmet
    {
        private string ime;

        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Ime { get => ime; set => ime = value; }


        [Range(1, 8)]
        [DataType(DataType.Text)]
        public decimal Semestar { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Programa { get; set; }

        public ICollection<PredmetProfesor>? Profesors { get; set; }
        public int ProfesorId { get; internal set; }

        internal static object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal static Task ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}