using Football.Application.Position;
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
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService;
        public PositionController(IPositionService playerservice)
        {
            _positionService = playerservice;
        }
        [HttpPost]
        public IActionResult Add([FromBody] AddPositionDto position)
        {
            _positionService.Add(position);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdatePositionDto position)
        {
            _positionService.Update(position);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromBody] DeletePositionDto position)
        {
            _positionService.Delete(position);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get([FromBody] GetPositionDto position)
        {
            if (position.Id != 0)
            {
                var result = _positionService.GetById(position);
                return Ok(result);
            }
            var all = _positionService.GetAll();
            return Ok(all);
        }
    }
}
