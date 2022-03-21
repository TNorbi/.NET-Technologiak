using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoRythmicsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmsController : ControllerBase
    {
        private IAlgorithmService _service;

        public AlgorithmsController(IAlgorithmService service)
        {
            _service = service;
        }

        [HttpPost("add-algorithm")]
        public IActionResult AddNewAlgorithm(AlgorithmViewModel viewModel)
        {
            _service.AddAlgorithm(viewModel);

            return Ok();
        }


        [HttpGet("get-alborithm-by-id/{algorithmId}")]
        public async Task<IActionResult> GetSpecificAlgorithm(int algorithmId)
        {
            var result = await _service.GetSpecificAlgorithm(algorithmId);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpGet("get-all-algorithms")]
        public async Task<IActionResult> GetAllAlgorithms()
        {
            var result = await _service.GetAllAlgorithms();

            if(result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpPut("update-algorithm/{algorithmId}")]
        public async Task<IActionResult> UpdateAlgorithm(int algorithmId,AlgorithmViewModel viewModel)
        {
            var result = await _service.UpdateAlgorithm(algorithmId, viewModel);

            if(result != null)
            {
                return Ok("Update successfull");
            }

            return Problem(detail: "Update unsuccessfull", statusCode: 301);
        }
    }
}
