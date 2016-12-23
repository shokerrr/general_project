using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.DTO
{
    public class OrderDTO
    {
        public User Client { get; set; }
        public Advertisment Service { get; set; }
        public DateTime Date { get; set; }
    }
}
