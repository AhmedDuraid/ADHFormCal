using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class TemperatureConvertingController : ControllerBase
    {
        private readonly ITemperatureConvertingOperations _temperatureConvertingOperations;
        private TemperatureModel Results;

        public TemperatureConvertingController(ITemperatureConvertingOperations temperatureConvertingOperations)
        {
            _temperatureConvertingOperations = temperatureConvertingOperations;
        }

        // GET: api/converting/Temperature/FromC
        [HttpGet("{valueInC}")]
        public IActionResult FromC(double valueInC)
        {
            try
            {
                Results = _temperatureConvertingOperations.FromC(valueInC);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/Temperature/FromF
        [HttpGet("{valueInCF}")]
        public IActionResult FromF(double valueInCF)
        {
            try
            {
                Results = _temperatureConvertingOperations.FromF(valueInCF);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/Temperature/FromK
        [HttpGet("{valueInK}")]
        public IActionResult FromK(double valueInK)
        {
            try
            {
                Results = _temperatureConvertingOperations.FromK(valueInK);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
