using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class SousAxe
    {
        public SousAxe()
        {
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string LabelAr { get; set; }
        public int IdAxe { get; set; }
        public Axe Axe { get; set; }
        // [System.Text.Json.Serialization.JsonIgnore]
    }
}
