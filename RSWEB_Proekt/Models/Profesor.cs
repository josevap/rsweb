using System.ComponentModel.DataAnnotations;
namespace RSWEB_Proekt.Models
{
    public class Profesor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string StepenNaObrazovanie { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string AkademskiRang { get; set; }
        
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

        public ICollection<Predmet>? Predmets { get; set; }
    }
}
