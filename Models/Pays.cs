using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Admin5.Models
{
    public partial class Pays
    {
        public Pays()
        {
            Recommendations = new HashSet<Recommendation>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string NomAr { get; set; }
        
        // [JsonIgnore]
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
