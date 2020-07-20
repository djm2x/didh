using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Visite
    {
        public Visite()
        {
            Recommendations = new HashSet<Recommendation>();
        }
        public int Id { get; set; }
        // public string Objet { get; set; }
        public string Mandat { get; set; }
        public string MandatAr { get; set; }
        public string Discours { get; set; }
        public string DiscoursAr { get; set; }
        public DateTime? Date { get; set; }
        public string LienRapport { get; set; }
        public string MiseOeuvrePiece { get; set; }
        public string LienUpload { get; set; }

        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
