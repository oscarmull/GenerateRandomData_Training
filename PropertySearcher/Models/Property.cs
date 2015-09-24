using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertySearcher.Models
{
    public class Property
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public decimal LastSoldPrice { get; set; }
        public string PropertyType { get; set; }

        // Foreign Key
        public int ResearchID { get; set; }
        // Navigation property
        public Researcher Researcher { get; set; }

    }
}