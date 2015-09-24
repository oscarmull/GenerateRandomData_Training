using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PropertySearcher.Models
{
    public class Researcher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}