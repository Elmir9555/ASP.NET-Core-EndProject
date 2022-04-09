using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<ProTeacher> ProTeachers { get; set; }
        public HomeAbout HomeAbout { get; set; }
        public CourseOffer CourseOffer { get; set; }
        public List<HomeCourses> HomeCourses { get; set; }
        public Video Video { get; set; }
        public List<Notices> Notices { get; set; }
        public List<HomeEventsDown> HomeEventsDown { get; set; }
        public List<HomeEventsUp> HomeEventsUp { get; set; }
        public HomeEventsHeader HomeEventsHeader { get; set; }
        public HomeStudent HomeStudent { get; set; }
        public List<HomeBlog> HomeBlogs { get; set; }
        public HomeBlogHeader HomeBlogHeader { get; set; }

    }
}
