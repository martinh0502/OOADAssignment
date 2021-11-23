using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BengansBowling.Services;

namespace BengansBowling.Controllers
{
    public class HomeController : Controller
    {
        private ICompetitionService _competitionService;
        private IMemberService _memberService;

        public HomeController(ICompetitionService competitionService, IMemberService memberService)
        {
            _competitionService = competitionService;
            _memberService = memberService;
        }
        public IActionResult Index()
        {
            //Jag har satt en breakpoint när tävlingen ska sparas ned i en databas.
            //Du kan kolla i objektet som ska sparas ned vad resultat i tävlingen blev.


            _competitionService.PlayCompetition(_memberService.GetMembers());
            return View();
        }
    }
}
