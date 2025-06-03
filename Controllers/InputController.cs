using Microsoft.AspNetCore.Mvc;
using InputCounterAPI.Models;
using InputCounterAPI.Services;

namespace InputCounterAPI.Controllers
{
    [ApiController]
    [Route("api/input")]
    public class InputController : ControllerBase
    {
        private readonly InputService _inputService;

        public InputController(InputService inputService)
        {
            _inputService = inputService;
        }

        [HttpPost]
        public IActionResult ProcessUserInputs([FromBody] UserInputModel model)
        {
            var parsedInputs = _inputService.ParseInputs(model.Inputs);
            var result = _inputService.CountOccurrences(parsedInputs);

            return Ok(result);
        }
    }
}
