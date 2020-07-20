using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Rapport
    {
        public Rapport()
        {
            Syntheses = new HashSet<Synthese>();
        }

        public int Id { get; set; }
        public string Titre { get; set; }
        public DateTime? DateDernierRapport { get; set; }
        public DateTime? DateObservation { get; set; }
        public DateTime? DateProchaineRapport { get; set; }
        public string Reference { get; set; }
        public string PieceJointe { get; set; }
        public int? IdTraite { get; set; }
        
        public virtual Traite Traite { get; set; }
        
        public virtual ICollection<Synthese> Syntheses { get; set; }
    }
}
