using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.ViewModels
{
    public class PredmetFilter
    {
        public IList<Predmet> predmets { get; set; }

        public SelectList programi { get; set; }

        public SelectList semestri { get; set; }

        public string Programa { get; set; }

        public string ime { get; set; }

        public int Semestar { get; set; }
    }
}
