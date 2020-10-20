using System;
using System.Collections.Generic;
namespace Admin5.Models
{
    public partial class Evenement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleAr { get; set; }
        public string Description { get; set; }
        public string DescriptionAr { get; set; }
        public string Categorie { get; set; }
        public DateTime Date { get; set; }
    }
}
