using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsLizardSpock.services;

namespace RockPaperScissorsLizardSpock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RockPaperScissorsLizardSpockController : ControllerBase
    {
        private readonly RockPaperScissorsLizardSpockService _RockPaperScissorsLizardSpockService;
        public RockPaperScissorsLizardSpockController (RockPaperScissorsLizardSpockService rockPaperScissorsLizardSpockService)
        {
            _RockPaperScissorsLizardSpockService = rockPaperScissorsLizardSpockService;
        }

        [HttpGet]
        [Route("Game")]
        public string Game()
        {
            return _RockPaperScissorsLizardSpockService.GameMethod();
        }
    }
}