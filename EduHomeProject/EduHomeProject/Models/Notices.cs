using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class Notices:BaseEntity
    {
        public string Date { get; set; }
        public string Notice { get; set; }
        public string Size { get; set; }
    }
}
