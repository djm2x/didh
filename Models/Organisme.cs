using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class Organisme
    {
        public Organisme()
        {
            User = new HashSet<User>();
            FicheSynthese = new HashSet<FicheSynthese>();
            RecomOrgs = new HashSet<RecomOrg>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string LabelAr { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        // [System.Text.Json.Serialization.JsonIgnore]
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<FicheSynthese> FicheSynthese { get; set; }
        public virtual ICollection<RecomOrg> RecomOrgs { get; set; }
    }
}
