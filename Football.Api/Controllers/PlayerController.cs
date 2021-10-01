using Football.Application.Player;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerservice)
        {
            _playerService = playerservice;
        }
        [HttpPost]
        public IActionResult Add([FromBody]AddPlayerDto player)
        {
            _playerService.Add(player);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdatePlayerDto player)
        {
            _playerService.Update(player);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] DeletePlayerDto player)
        {
            _playerService.Delete(player);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get([FromBody] GetPlayerDto player)
        {
            var result = _playerService.GetAll();
            switch (player.GetBy.ToLower())
            {
                case "id": result = _playerService.GetById(player).OrderBy(x => x.Id).ToList(); break;
                case "name": result = _playerService.GetByName(player).OrderBy(x => x.Name).ToList(); break;
                case "lastname": result = _playerService.GetByLastName(player).OrderBy(x => x.LastName).ToList(); break;
                case "age": result = _playerService.GetByAge(player).OrderBy(x => x.Age).ToList(); break;
                case "positionid": result = _playerService.GetByPositionId(player).OrderBy(x => x.PositionId).ToList(); break;
                case "teamid": result = _playerService.GetByTeamId(player).OrderBy(x => x.TeamId).ToList(); break;
                default: break;
            }
            if (result != null)
                return Ok(result);
            return NotFound();

            /*var result = _playerService.Get(player);
            if (result != null)
                return Ok(result);
            return NotFound();*/
        }

    }
}