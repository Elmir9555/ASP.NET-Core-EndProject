
using EduHomeProject.Data;
using EduHomeProject.Models;
using EduHomeProject.Services;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;

        public HomeController(AppDbContext context, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
        }
       

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Slider.ToListAsync();
            List<ProTeacher> proTeachers = await _context.ProTeacher.ToListAsync();
            HomeAbout homeAbout = await _context.HomeAbout.FirstOrDefaultAsync();
            CourseOffer courseOffer = await _context.CourseOffer.FirstOrDefaultAsync();
            List<HomeCourses> homeCourses = await _context.HomeCourses.ToListAsync();
            Video video = await _context.Video.FirstOrDefaultAsync();
            List<Notices> notices = await _context.Notices.ToListAsync();
            List<HomeEventsUp> homeEventsUp = await _context.HomeEventsUp.ToListAsync();
            List<HomeEventsDown> homeEventsDown = await _context.HomeEventsDown.ToListAsync();
            HomeStudent homeStudent = await _context.HomeStudent.FirstOrDefaultAsync();
            HomeEventsHeader homeEventsHeader = await _context.HomeEventsHeader.FirstOrDefaultAsync();
            List<HomeBlog> homeBlogs = await _context.HomeBlogs.ToListAsync();
            HomeBlogHeader homeBlogHeader = await _context.HomeBlogHeader.FirstOrDefaultAsync();
            Settings settings = await _layoutService.GetSettings();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                ProTeachers =proTeachers,
                HomeAbout =homeAbout,
                CourseOffer =courseOffer,
                HomeCourses=homeCourses,
                Video=video,
                Notices=notices,
                HomeEventsDown=homeEventsDown,
                HomeEventsUp=homeEventsUp,
                HomeStudent=homeStudent,
                HomeEventsHeader=homeEventsHeader,
                HomeBlogs=homeBlogs,
                HomeBlogHeader=homeBlogHeader,

            };

            return View(homeVM);
        }

       
    }
}
