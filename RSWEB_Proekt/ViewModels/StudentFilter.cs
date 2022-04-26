using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.ViewModels
{
    public class StudentFilter
    {
        public IList<Student> students { get; set; }

        public SelectList firstName { get; set; }

        public SelectList lastName { get; set; }

        public SelectList index { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Index { get; set; }
    }
}
