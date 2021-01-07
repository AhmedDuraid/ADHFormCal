using ADHFormCalAPI.Calculator.Converters;
using ADHFormCalAPI.Models.Converters;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ADHFormCalAPI.Controllers.Converters
{
    [Route("api/converting/[controller]/[action]")]
    [ApiController]
    public class TimeConvertingController : ControllerBase
    {
        private readonly ITimeConvertingOperations _timeConvertingOperations;
        private TimeModel Results;

        public TimeConvertingController(ITimeConvertingOperations timeConvertingOperations)
        {
            _timeConvertingOperations = timeConvertingOperations;
        }

        // GET: api/converting/TimeConverting/FromDay
        [HttpGet("{valueInDay}")]
        public IActionResult FromDay(double valueInDay)
        {
            try
            {
                Results = _timeConvertingOperations.FromDay(valueInDay);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/TimeConverting/FromHour
        [HttpGet("{valueInHour}")]
        public IActionResult FromHour(double valueInHour)
        {
            try
            {
                Results = _timeConvertingOperations.FromHour(valueInHour);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/TimeConverting/FromMinute
        [HttpGet("{valueInMinute}")]
        public IActionResult FromMinute(double valueInMinute)
        {
            try
            {
                Results = _timeConvertingOperations.FromMinute(valueInMinute);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/TimeConverting/FromMonth
        [HttpGet("{valueInMonth}")]
        public IActionResult FromMonth(double valueInMonth)
        {
            try
            {
                Results = _timeConvertingOperations.FromMonth(valueInMonth);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/TimeConverting/FromSecond
        [HttpGet("{valueInSecond}")]
        public IActionResult FromSecond(double valueInSecond)
        {
            try
            {
                Results = _timeConvertingOperations.FromSecond(valueInSecond);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/converting/TimeConverting/FromWeek
        [HttpGet("{valueInWeek}")]
        public IActionResult FromWeek(double valueInWeek)
        {
            try
            {
                Results = _timeConvertingOperations.FromWeek(valueInWeek);

                return Ok(Results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
