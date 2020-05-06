using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class RecomOrg
    {
        public int IdRecommendation { get; set; }
        public int IdOrganisme { get; set; }
        public DateTime Date { get; set; }
        public Organisme Organisme { get; set; }
        public Recommendation Recommendation { get; set; }
    }
}
