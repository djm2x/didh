using System;
using System.Collections.Generic;

namespace Admin5.Models
{
    public partial class FicheSynthese
    {
        public int Id { get; set; }
        public string FicheUrl { get; set; }
        public int IdOrganisme { get; set; }
        public int IdSynthese { get; set; }
        public virtual Organisme Organisme { get; set; }
        public virtual Synthese Synthese { get; set; }
    }
}
