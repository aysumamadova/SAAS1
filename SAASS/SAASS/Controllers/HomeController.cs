using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SAASS.DAL;
using SAASS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SAASS.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Sliders.ToListAsync();
            return View(slider);
        }

       
    }
}
