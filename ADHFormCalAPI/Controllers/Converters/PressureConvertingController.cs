using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class PressureConvertingController : ControllerBase
    {
        private readonly IPressureConvertingOperations _pressureConvertingOperations;
        private PressureModel Results;

        public PressureConvertingController(IPressureConvertingOperations pressureConvertingOperations)
        {
            _pressureConvertingOperations = pressureConvertingOperations;
        }

        // GET: api/converting/PressureConverting/FromBar
        [HttpGet("{valueInBar}")]
        public IActionResult FromBar(double valueInBar)
        {
            try
            {
                Results = _pressureConvertingOperations.FromBar(valueInBar);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/converting/PressureConverting/FromPascals
        [HttpGet("{valueInPascals}")]
        public IActionResult FromPascals(double valueInPascals)
        {
            try
            {
                Results = _pressureConvertingOperations.FromPascals(valueInPascals);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/converting/PressureConverting/FromTorr
        [HttpGet("{valueInTorr}")]
        public IActionResult FromTorr(double valueInTorr)
        {
            try
            {
                Results = _pressureConvertingOperations.FromTorr(valueInTorr);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
