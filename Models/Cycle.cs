using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Admin5.Models
{
    public partial class Cycle
    {
        public Cycle()
        {
            Recommendations = new HashSet<Recommendation>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        
        // [JsonIgnore]
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
