using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Questionnaire
    {
        public int Id { get; set; }
        public int Annee { get; set; }
        public string Theme { get; set; }
        public string SousTheme { get; set; }
        public string PieceJointe { get; set; }
    }
}
