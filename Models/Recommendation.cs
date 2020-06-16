using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Recommendation
    {
        public Recommendation()
        {
            RecomOrgs = new HashSet<RecomOrg>();
            SyntheseRecommandations = new HashSet<SyntheseRecommandation>();
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string CodeRecommendation { get; set; }
        public string Mecanisme { get; set; }
        public int? IdCycle { get; set; }
        public int IdAxe { get; set; }
        public int IdSousAxe { get; set; }
        public int? IdOrgane { get; set; }
        public int? IdVisite { get; set; }
        public int? IdPays { get; set; }
        public string Etat { get; set; }
        public string EtatAvancement { get; set; }
        public int EtatAvancementChiffre { get; set; }
        public string Observation { get; set; }
        public string PieceJointe { get; set; }
        // public int IdOrganisme { get; set; }
        // public Organisme Organisme { get; set; }
        public Visite Visite { get; set; }
        public Organe Organe { get; set; }
        public Axe Axe { get; set; }
        public SousAxe SousAxe { get; set; }
        public Cycle Cycle { get; set; }
        public Pays Pays { get; set; }
        public virtual ICollection<RecomOrg> RecomOrgs { get; set; }
        public virtual ICollection<SyntheseRecommandation> SyntheseRecommandations { get; set; }
    }
}
