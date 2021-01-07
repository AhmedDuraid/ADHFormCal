using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class SpeedConvertingController : ControllerBase
    {
        private readonly ISpeedConvertingOperations _speedConvertingOperations;
        private SpeedModel Results;

        public SpeedConvertingController(ISpeedConvertingOperations speedConvertingOperations)
        {
            _speedConvertingOperations = speedConvertingOperations;
        }

        // GET: api/converting/SpeedConverting/FromKilometersPerHour
        [HttpGet("{valueInKilometers}")]
        public IActionResult FromKilometersPerHour(double valueKilometers)
        {
            try
            {
                Results = _speedConvertingOperations.FromKilometersPerHour(valueKilometers);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/SpeedConverting/FromKnots
        [HttpGet("{valueInKnots}")]
        public IActionResult FromKnots(double valueKnots)
        {
            try
            {
                Results = _speedConvertingOperations.FromKnots(valueKnots);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/SpeedConverting/FromMile
        [HttpGet("{valueInMile}")]
        public IActionResult FromMile(double valueKilometers)
        {
            try
            {
                Results = _speedConvertingOperations.FromMile(valueKilometers);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
