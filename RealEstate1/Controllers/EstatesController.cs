using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate1.Data;
using RealEstate1.Data.Services;

namespace RealEstate1.Controllers
{
    public class EstatesController : Controller
    {
        private readonly IEstatesService _service;

        public EstatesController(IEstatesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allEstates = await _service.GetAll();
            return View(allEstates);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
