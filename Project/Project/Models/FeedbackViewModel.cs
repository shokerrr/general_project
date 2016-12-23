using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;

namespace Project.Models
{
    public class FeedbackViewModel
    {
        public Advertisment Service { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public Rate Mark { get; set; }
    }
}