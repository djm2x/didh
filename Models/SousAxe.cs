using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class SousAxe
    {
        public SousAxe()
        {
            Recommendations = new HashSet<Recommendation>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public int IdAxe { get; set; }
        public Axe Axe { get; set; }
        // [System.Text.Json.Serialization.JsonIgnore]
        public virtual ICollection<Recommendation> Recommendations { get; set; }
    }
}
