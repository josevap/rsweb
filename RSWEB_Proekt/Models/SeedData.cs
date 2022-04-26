using Microsoft.EntityFrameworkCore;
using RSWEB_Proekt.Data;

namespace RSWEB_Proekt.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RSWEB_ProektContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RSWEB_ProektContext>>()))
            {
                if (context.Predmet.Any() || context.Profesor.Any() || context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Profesor.AddRange(
                    new Profesor { /*Id = 1, */FirstName = "Ana", LastName = "Ilieva", StepenNaObrazovanie = "Doktorski studii", AkademskiRang = "Vonreden profesor" },
                    new Profesor { /*Id = 2, */FirstName = "Jovan", LastName = "Srebrenov", StepenNaObrazovanie = "Magisterski studii", AkademskiRang = "Docent" },
                    new Profesor { /*Id = 3, */FirstName = "Verica", LastName = "Gjorgievska", StepenNaObrazovanie = "Doktorski studii", AkademskiRang = "Redoven profesor" }
                );
                context.SaveChanges();

                context.Student.AddRange(
                    new Student { /*Id = 1, */FirstName = "Marija", LastName = "Stefanovska", Index="133/2017" },
                    new Student { /*Id = 2, */FirstName = "Lora", LastName = "Matieva", Index = "194/2018" },
                    new Student { /*Id = 3, */FirstName = "Dimitar", LastName = "Lazov", Index = "62/2016" },
                    new Student { /*Id = 4, */FirstName = "Matej", LastName = "Trajkovski", Index = "278/2017" },
                    new Student { /*Id = 5, */FirstName = "Aleksandar", LastName = "Lekov", Index = "209/2017" },
                    new Student { /*Id = 6, */FirstName = "Ivana", LastName = "Angelova", Index = "105/2018" }
                );
                context.SaveChanges();

                context.Predmet.AddRange(
                    new Predmet
                    {
                        //Id = 1,
                        Ime = "Razvoj na serverski Web Aplikacii",
                        Semestar = 6,
                        Programa = "KTI",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Jovan" && d.LastName == "Srebrenov").Id
                    },
                    new Predmet
                    {
                        //Id = 2,
                        Ime = "Fizika na kompjuterski igri",
                        Semestar = 6,
                        Programa = "KTI",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Ana" && d.LastName == "Ilieva").Id
                    },
                    new Predmet
                    {
                        //Id = 3,
                        Ime = "Matematika 3",
                        Semestar = 3,
                        Programa = "Site",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Verica" && d.LastName == "Gjorgievska").Id
                    });
                context.SaveChanges();

                context.StudentPredmet.AddRange(
                    new StudentPredmet { StudentId = 1, PredmetId = 1 },
                    new StudentPredmet { StudentId = 3, PredmetId = 1 },
                    new StudentPredmet { StudentId = 4, PredmetId = 1 },
                    new StudentPredmet { StudentId = 2, PredmetId = 2 },
                    new StudentPredmet { StudentId = 5, PredmetId = 2 },
                    new StudentPredmet { StudentId = 4, PredmetId = 2 },
                    new StudentPredmet { StudentId = 1, PredmetId = 3 },
                    new StudentPredmet { StudentId = 3, PredmetId = 3 },
                    new StudentPredmet { StudentId = 6, PredmetId = 3 }
                );
                context.SaveChanges();
            }
        }
    }
}
