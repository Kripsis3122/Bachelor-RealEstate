using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate1.Data;
using RealEstate1.Data.Services;
using RealEstate1.Models;

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

            if (estateDetails == null) return View("Empty");
            return View(estateDetails);
        }

		//Get Estates/Update
		public async Task<IActionResult> Edit(int id)
		{
			var estateDetails = await _service.GetByIdAsync(id);

			if (estateDetails == null) return View("Not found");
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

            if (estateDetails == null) return View("Not found");
            return View(estateDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estateDetails = await _service.GetByIdAsync(id);

            if (estateDetails == null) return View("Not found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
