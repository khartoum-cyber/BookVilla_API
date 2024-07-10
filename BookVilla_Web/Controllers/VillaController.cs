﻿using AutoMapper;
using BookVilla_Web.Models;
using BookVilla_Web.Models.DTO;
using BookVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;

namespace BookVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();

            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

		public async Task<IActionResult> CreateVilla()
		{
			return View();
		}

        [HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> CreateVilla(VillaDTOcreate model)
		{
            if (ModelState.IsValid)
            {
                var response = await _villaService.CreateAsync<APIResponse>(model);
                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Villa created successfully.";
                    return RedirectToAction(nameof(IndexVilla));
                }
            }
            TempData["error"] = "Error !";
            return View(model);
		}

		public async Task<IActionResult> UpdateVilla(int villaId)
		{
			var response = await _villaService.GetAsync<APIResponse>(villaId);
			if (response != null && response.IsSuccess)
			{
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
				return View(_mapper.Map<VillaDTOupdate>(model));
			}
			return NotFound();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> UpdateVilla(VillaDTOupdate model)
		{
			if (ModelState.IsValid)
			{
                TempData["success"] = "Villa updated successfully.";
                var response = await _villaService.UpdateAsync<APIResponse>(model);
				if (response != null && response.IsSuccess)
				{
					return RedirectToAction(nameof(IndexVilla));
				}
			}
            TempData["error"] = "Error !";
            return View(model);
		}

        public async Task<IActionResult> DeleteVilla(int villaId)
        {
            var response = await _villaService.GetAsync<APIResponse>(villaId);
            if (response != null && response.IsSuccess)
            {
                VillaDTO model = JsonConvert.DeserializeObject<VillaDTO>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteVilla(VillaDTO model)
        {
            var response = await _villaService.DeleteAsync<APIResponse>(model.Id);
            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Villa deleted successfully.";
                return RedirectToAction(nameof(IndexVilla));
            }
            TempData["error"] = "Error !";
            return View(model);
        }
    }
}
