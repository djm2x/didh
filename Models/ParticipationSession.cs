using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class ParticipationSession
    {
        public int Id { get; set; }
        public int Annee { get; set; }
        public string Session { get; set; }
        public string Discours { get; set; }
        public string Documents { get; set; }
    }
}
