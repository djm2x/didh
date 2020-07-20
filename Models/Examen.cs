using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Examen
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string LibelleAr { get; set; }
        public string Discours { get; set; }
        public string RapportNational { get; set; }
        public string CompilationHCDH { get; set; }
        public string ObservationFinale { get; set; }
        public string RapportMiParcours { get; set; }
        public string MiseOeuvrePiece { get; set; }
    }
}
