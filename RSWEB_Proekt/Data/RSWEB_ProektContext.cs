#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.Data
{
    public class RSWEB_ProektContext : DbContext
    {
        public RSWEB_ProektContext (DbContextOptions<RSWEB_ProektContext> options)
            : base(options)
        {
        }

        public DbSet<RSWEB_Proekt.Models.Predmet> Predmet { get; set; }

        public DbSet<RSWEB_Proekt.Models.Profesor> Profesor { get; set; }

        public DbSet<RSWEB_Proekt.Models.Student> Student { get; set; }

        public DbSet<PredmetProfesor> PredmetProfesor { get; set; }

        public DbSet<StudentPredmet> StudentPredmet { get; set; }

    }
}
