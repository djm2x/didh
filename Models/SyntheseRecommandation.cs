using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class SyntheseRecommandation
    {
        public int IdRecommandation { get; set; }
        public int IdSynthese { get; set; }
        public Recommendation Recommendation { get; set; }
        public Synthese Synthese { get; set; }
    }
}
