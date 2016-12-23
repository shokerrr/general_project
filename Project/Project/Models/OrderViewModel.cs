using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Domain;

namespace Project.Models
{
    public class OrderViewModel
    {
        [Required]
        public User Client { get; set; }
        [Required]
        public Advertisment Service { get; set; }
        public DateTime Date { get; set; }
    }
}