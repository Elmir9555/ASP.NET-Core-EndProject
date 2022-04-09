using EduHomeProject.Data;
using EduHomeProject.Models;
using EduHomeProject.Services;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly LayoutService _layoutService;
        private readonly AppDbContext _context;
        public FooterViewComponent(LayoutService layoutService, AppDbContext context)
        {
            _layoutService = layoutService;
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Settings settings = await _layoutService.GetSettings();
            List<SocialNetwork> socialNetworks = await _layoutService.GetSocialNetwork();
            
            LayoutVM layoutVM = new LayoutVM()
            {
                Settings=settings,
                SocialNetwork=socialNetworks
            };
            return (await Task.FromResult(View(layoutVM)));
        }
    }
}
