using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class VolumeConvertingController : ControllerBase
    {
        private VolumeModel Results;
        private readonly IVolumeConvertingOperations _volumeConvertingOperations;

        public VolumeConvertingController(IVolumeConvertingOperations volumeConvertingOperations)
        {
            _volumeConvertingOperations = volumeConvertingOperations;
        }

        // GET: api/converting/VolumeConverting/FromCentiliter
        [HttpGet("{valueInCentiliter}")]
        public IActionResult FromCentiliter(double valueInCentiliter)
        {
            try
            {
                Results = _volumeConvertingOperations.FromCentiliter(valueInCentiliter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromCubicMeter
        [HttpGet("{valueInCubicMeter}")]
        public IActionResult FromCubicMeter(double valueInCubicMeter)
        {
            try
            {
                Results = _volumeConvertingOperations.FromCubicMeter(valueInCubicMeter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromLiter
        [HttpGet("{valueInLiter}")]
        public IActionResult FromLiter(double valueInLiter)
        {
            try
            {
                Results = _volumeConvertingOperations.FromLiter(valueInLiter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromMilliliter
        [HttpGet("{valueInMilliliter}")]
        public IActionResult FromMilliliter(double valueInMilliliter)
        {
            try
            {
                Results = _volumeConvertingOperations.FromMilliliter(valueInMilliliter);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUKGallon
        [HttpGet("{valueInUKGallon}")]
        public IActionResult FromUKGallon(double valueInUKGallon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUKGallon(valueInUKGallon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUKTablespoon
        [HttpGet("{valueInUKTablespoon}")]
        public IActionResult FromUKTablespoon(double valueInUKTablespoon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUKTablespoon(valueInUKTablespoon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUKTeaspoon
        [HttpGet("{valueInUKTeaspoon}")]
        public IActionResult FromUKTeaspoon(double valueInUKTeaspoon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUKTeaspoon(valueInUKTeaspoon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUSGallon
        [HttpGet("{valueInUSGallon}")]
        public IActionResult FromUSGallon(double valueInUSGallon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUSGallon(valueInUSGallon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUSTablespoon
        [HttpGet("{valueInUSTablespoon}")]
        public IActionResult FromUSTablespoon(double valueInUSTablespoon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUSTablespoon(valueInUSTablespoon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/VolumeConverting/FromUSTeaspoon
        [HttpGet("{valueInUSTeaspoon}")]
        public IActionResult FromUSTeaspoon(double valueInUSTeaspoon)
        {
            try
            {
                Results = _volumeConvertingOperations.FromUSTeaspoon(valueInUSTeaspoon);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
