using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConferenceWebApp.Services;
using Shared.Models;

namespace ConferenceWebApp.Controllers
{
    public class ConferenceController: Controller
    {
        private readonly IConferenceService service;
        public ConferenceController(IConferenceService service)
        {
            this.service = service;
        }

        public IConferenceService Service { get; }

        public async Task<IActionResult> Index()
        {
            ViewBag.title = "Conference Overview";
            return View(await service.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.title = "Add Conference";
            return View(new ConferenceModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ConferenceModel model)
        {
            if (ModelState.IsValid)
                await service.Add(model);

            return RedirectToAction("Index");
        }
    }
}
