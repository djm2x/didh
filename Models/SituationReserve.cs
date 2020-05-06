using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Admin5.Models
{
    public partial class SituationReserve
    {
        public SituationReserve()
        {
           
        }

        public int Id { get; set; }
        public string Url { get; set; }
    }
}
