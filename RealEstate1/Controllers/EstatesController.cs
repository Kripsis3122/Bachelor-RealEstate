using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate1.Data;

namespace RealEstate1.Controllers
{
    public class EstatesController : Controller
    {
        private readonly AppDbContext _context;

        public EstatesController(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index()
        {
            var allEstates = await _context.Estates.ToListAsync();
            return View(allEstates);
        }
    }
}
