using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate1.Data;
using RealEstate1.Data.Services;
using RealEstate1.Models;
using System.Text.RegularExpressions;

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
            var allEstates = await _service.GetAllAsync();
            return View(allEstates);
        }

		public async Task<IActionResult> Search(string searchString)
		{
			var allEstates = await _service.GetAllAsync();

			if (!string.IsNullOrEmpty(searchString))
			{

                var filteredResult = allEstates.Where(e => e.Name.ToUpperInvariant().Contains(searchString.ToUpperInvariant()) || e.Description.ToUpperInvariant().Contains(searchString.ToUpperInvariant())).ToList();

                return View("Index", filteredResult);
			}

			return View("Index", allEstates);
		}

        public async Task<IActionResult> Filter(int category)
        {
            var allEstates = await _service.GetAllAsync();
            
            var filteredResult = allEstates.Where(e => (int)e.EstateCategory==category).ToList();

            return View("Index", filteredResult);
        }
		public async Task<IActionResult> SortByName()
		{
			var allEstates = await _service.GetAllAsync();
			var sortedEstates = allEstates.OrderBy(e => e.Name).ToList();

			return View("Index", sortedEstates);
		}
		public async Task<IActionResult> SortByPriceAsc()
		{
			var allEstates = await _service.GetAllAsync();
			var sortedEstates = allEstates.OrderBy(e => e.Price).ToList();

			return View("Index", sortedEstates);
		}

		public async Task<IActionResult> SortByPriceDesc()
		{
			var allEstates = await _service.GetAllAsync();

			var sortedEstates = allEstates.OrderByDescending(e => e.Price).ToList();

			return View("Index", sortedEstates);
		}
		public async Task<IActionResult> SortByDateAsc()
		{
			var allEstates = await _service.GetAllAsync();

			var sortedEstates = allEstates.OrderBy(e => e.date_added).ToList();

			return View("Index", sortedEstates);
		}
		public async Task<IActionResult> SortByDateDesc()
		{
			var allEstates = await _service.GetAllAsync();

			var sortedEstates = allEstates.OrderByDescending(e => e.date_added).ToList();

			return View("Index", sortedEstates);
		}

		//Get Estates/Create
		public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Estate estate)
		{
            if (!ModelState.IsValid)
            {
                return View(estate);
            }

            await _service.AddAsync(estate);

            return RedirectToAction(nameof(Index));
        }

		//Get Estates/Details/ID
        public async Task<IActionResult> Details(int id)
        {
            var estateDetails = await _service.GetByIdAsync(id);

            if (estateDetails == null) return View("NotFound");
            return View(estateDetails);
        }

		//Get Estates/Update
		public async Task<IActionResult> Edit(int id)
		{
			var estateDetails = await _service.GetByIdAsync(id);

			if (estateDetails == null) return View("NotFound");
			return View(estateDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, Estate estate)
		{
			if (!ModelState.IsValid)
			{
				return View(estate);
			}

			await _service.EditAsync(id,estate);

			return RedirectToAction(nameof(Index));
		}

        //Get Estates/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var estateDetails = await _service.GetByIdAsync(id);

            if (estateDetails == null) return View("NotFound");
            return View(estateDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estateDetails = await _service.GetByIdAsync(id);

            if (estateDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
