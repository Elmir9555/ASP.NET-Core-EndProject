using EduHomeProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<ProTeacher> ProTeacher { get; set; }
        public DbSet<HomeAbout> HomeAbout { get; set; }
        public DbSet<CourseOffer> CourseOffer { get; set; }
        public DbSet<HomeCourses> HomeCourses { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Notices> Notices { get; set; }
        public DbSet<HomeEventsUp> HomeEventsUp { get; set; }
        public DbSet<HomeEventsDown> HomeEventsDown { get; set; }
        public DbSet<HomeStudent> HomeStudent { get; set; }
        public DbSet<HomeEventsHeader> HomeEventsHeader { get; set; }
        public DbSet<HomeBlog> HomeBlogs { get; set; }
        public DbSet<HomeBlogHeader> HomeBlogHeader { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
    }
}
