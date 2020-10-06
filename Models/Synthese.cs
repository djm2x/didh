using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Synthese
    {
        public Synthese()
        {
            FicheSyntheses = new HashSet<FicheSynthese>();
            SyntheseRecommandations = new HashSet<SyntheseRecommandation>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Detail { get; set; }
        public string DetailAr { get; set; }
        public int? IdRapport { get; set; }
        public int IdUser { get; set; }
        public Rapport Rapport { get; set; }
        public User User { get; set; }

        public virtual ICollection<FicheSynthese> FicheSyntheses { get; set; }
        public virtual ICollection<SyntheseRecommandation> SyntheseRecommandations { get; set; }

    }
}
