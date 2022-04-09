using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Models
{
    public class HomeBlog:BaseEntity
    {
        public string Image { get; set; }
        public string From { get; set; }
        public string Date { get; set; }
        public int CommentCount { get; set; }
        public string Title { get; set; }
    }
}
