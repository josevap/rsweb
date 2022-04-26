using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.ViewModels
{
    public class ProfesorFilter
    {
        public IList<Profesor> profesors { get; set; }

        public SelectList firstName { get; set; }

        public SelectList lastName { get; set; }

        public SelectList akademskiRang { get; set; }

        public SelectList stepenNaObrazovanie { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AkademskiRang { get; set; }

        public string StepenNaObrazovanie { get; set; }
    }
}
