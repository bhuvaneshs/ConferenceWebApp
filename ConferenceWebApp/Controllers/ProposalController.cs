using ConferenceWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceWebApp.Controllers
{
    public class ProposalController: Controller
    {
        private readonly IConferenceService conferenceService;
        private readonly IProposalService proposalService;


        public ProposalController(IConferenceService conferenceService,IProposalService proposalService)
        {
            this.conferenceService = conferenceService;
            this.proposalService = proposalService;
        }

        public async Task<IActionResult> Index(int conferenceId)
        {
            var conference = await conferenceService.GetById(conferenceId);
            ViewBag.title = $"proposals for conference {conference.Name} {conference.Location}";
            ViewBag.conferenceId = conferenceId;

            return View(await proposalService.GetAll(conferenceId));
        }
        public IActionResult Add(int conferenceId)
        {
            ViewBag.title = 
                Add 
        }
    }

}
