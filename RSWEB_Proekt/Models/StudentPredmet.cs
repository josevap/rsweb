﻿namespace RSWEB_Proekt.Models
{
    public class StudentPredmet
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
    }
}