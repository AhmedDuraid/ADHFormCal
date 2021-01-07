using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class LengthConvertingController : ControllerBase
    {
        private readonly ILengthConvertingOperations _lengthConvertingOperations;
        private LengthModel Results;

        public LengthConvertingController(ILengthConvertingOperations lengthConvertingOperations)
        {
            _lengthConvertingOperations = lengthConvertingOperations;
        }

        // GET: api/converting/LengthConverting/fromCentimeters
        [HttpGet("{valueInCentimeters}")]
        public IActionResult FromCentimeters(double valueInCentimeters)
        {
            try
            {
                Results = _lengthConvertingOperations.FromCentimeters(valueInCentimeters);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/converting/LengthConverting/FromFoot
        [HttpGet("{valueInFoor}")]
        public IActionResult FromFoot(double valueInFoor)
        {
            try
            {
                Results = _lengthConvertingOperations.FromFoot(valueInFoor);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/converting/LengthConverting/FromInche
        [HttpGet("{valueInInche}")]
        public IActionResult FromInche(double valueInInche)
        {
            try
            {
                Results = _lengthConvertingOperations.FromInche(valueInInche);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        // GET: api/converting/LengthConverting/FromKilometers
        [HttpGet("{valueInKilometer}")]
        public IActionResult FromKilometers(double valueInKilometer)
        {
            try
            {
                Results = _lengthConvertingOperations.FromKilometers(valueInKilometer);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/LengthConverting/FromMeters
        [HttpGet("{valueInMeter}")]
        public IActionResult FromMeters(double valueInMeter)
        {
            try
            {
                Results = _lengthConvertingOperations.FromMeters(valueInMeter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/LengthConverting/FromMiles
        [HttpGet("{valueInMiles}")]
        public IActionResult FromMiles(double valueInMiles)
        {
            try
            {
                Results = _lengthConvertingOperations.FromMiles(valueInMiles);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/LengthConverting/FromMillimeter
        [HttpGet("{valueInMillimeter}")]
        public IActionResult FromMillimeter(double valueInMillimeter)
        {
            try
            {
                Results = _lengthConvertingOperations.FromMillimeter(valueInMillimeter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/LengthConverting/FromYard
        [HttpGet("{valueInYard}")]
        public IActionResult FromYard(double valueInYard)
        {
            try
            {
                Results = _lengthConvertingOperations.FromYard(valueInYard);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
