using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class WeightConvertingController : ControllerBase
    {
        private readonly IWeightConvertingOperations _weightConvertingOperations;
        private WeightModel Results;

        public WeightConvertingController(IWeightConvertingOperations weightConvertingOperations)
        {
            _weightConvertingOperations = weightConvertingOperations;
        }


        // GET: api/converting/WeightConverting/FromGrams
        [HttpGet("{valueInGrams}")]
        public IActionResult FromGrams(double valueInGrams)
        {
            try
            {
                Results = _weightConvertingOperations.FromGrams(valueInGrams);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/WeightConverting/FromKilograms
        [HttpGet("{valueInKilograms}")]
        public IActionResult FromKilograms(double valueInKilograms)
        {
            try
            {
                Results = _weightConvertingOperations.FromKilograms(valueInKilograms);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/WeightConverting/FromMilligrams
        [HttpGet("{valueInMilligrams}")]
        public IActionResult FromMilligrams(double valueInMilligrams)
        {
            try
            {
                Results = _weightConvertingOperations.FromMilligrams(valueInMilligrams);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/WeightConverting/FromOunces
        [HttpGet("{valueInOunces}")]
        public IActionResult FromOunces(double valueInOunces)
        {
            try
            {
                Results = _weightConvertingOperations.FromOunces(valueInOunces);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/WeightConverting/FromPounds
        [HttpGet("{valueInPounds}")]
        public IActionResult FromPounds(double valueInPounds)
        {
            try
            {
                Results = _weightConvertingOperations.FromPounds(valueInPounds);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/WeightConverting/FromTonnes
        [HttpGet("{valueInTonnes}")]
        public IActionResult FromTonnes(double valueInTonnes)
        {
            try
            {
                Results = _weightConvertingOperations.FromTonnes(valueInTonnes);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
