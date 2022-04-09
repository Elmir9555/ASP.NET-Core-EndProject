using EduHomeProject.Data;
using EduHomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Settings> GetSettings()
        {
            Settings settings = await _context.Settings.FirstOrDefaultAsync();
            return settings;
        }
        public async Task<List<SocialNetwork>> GetSocialNetwork()
        {
            List<SocialNetwork> socialNetworks = await _context.SocialNetworks.ToListAsync();
            return socialNetworks;
        }

    }
}
