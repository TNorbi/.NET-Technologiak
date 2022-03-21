using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoRythmicsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlgorithmsController : ControllerBase
    {
        private IAlgorithmService _service;

        public AlgorithmsController(IAlgorithmService service)
        {
            _service = service;
        }

        [HttpPost(Name ="add-new-algorithm")]
        public IActionResult AddNewAlgorithm(AlgorithmViewModel viewModel)
        {
            _service.AddAlgorithm(viewModel);

            return Ok();
        }

    }
}
