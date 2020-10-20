using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Questionnaire
    {
        public int Id { get; set; }
        public int Annee { get; set; }
        public int Theme { get; set; }
        public int SousTheme { get; set; }

        // public int ThemeAr { get; set; }
        // public int SousThemeAr { get; set; }
        public string Reporter  { get; set; }
        public string ReporterAr  { get; set; }
        public string PieceJointe { get; set; }
    }
}
