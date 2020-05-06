using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Admin5.Models
{
    public partial class Axe
    {
        public Axe()
        {
            SousAxes = new HashSet<SousAxe>();
            Recommendations = new HashSet<Recommendation>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        
        // [JsonIgnore]
        public virtual ICollection<SousAxe> SousAxes { get; set; }
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
