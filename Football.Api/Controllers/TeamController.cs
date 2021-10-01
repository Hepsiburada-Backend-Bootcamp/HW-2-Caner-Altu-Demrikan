using Football.Application.Team;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamService _teamService;
        public TeamController(ITeamService playerservice, ILogger<TeamController> logger)
        {
            _teamService = playerservice;
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Add([FromBody] AddTeamDto team)
        {
            _teamService.Add(team);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateTeamDto team)
        {
            _teamService.Update(team);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] DeleteTeamDto team)
        {
            _teamService.Delete(team);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get([FromBody] GetTeamDto team)
        {
            if (team.Id != 0)
            {
                var result = _teamService.GetById(team);
                return Ok(result);
            }
            var all = _teamService.GetAll();
            return Ok(all);
        }
    }
}
