using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class HomeEventsDown:BaseEntity
    {
        public string Image { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
    }
}
