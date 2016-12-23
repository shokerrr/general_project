using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;

namespace Project.Models
{
    public class RateViewModel
    {
        public Category CategoryRate { get; set; }
        public decimal Rating { get; set; }
    }
}