using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Traite
    {
        public Traite()
        {
            Rapports = new HashSet<Rapport>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string NomAr { get; set; }
        public string ConventionPiece { get; set; }
        public string MiseOeuvrePiece { get; set; }
        public string ObservationPiece { get; set; }
        public string AnalytiquePiece { get; set; }
        public string RapportParallelePiece { get; set; }
        public string Discours { get; set; }
        public string RapportINDH { get; set; }
        public string AvisPosition { get; set; }
        public DateTime DateRatification { get; set; }
        public DateTime DateSignature { get; set; }
        public virtual ICollection<Rapport> Rapports { get; set; }
    }
}
