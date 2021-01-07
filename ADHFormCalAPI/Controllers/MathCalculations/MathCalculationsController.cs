using ADHFormCalAPI.Calculator.MathcClculation;
using ADHFormCalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ADHFormCalAPI.Controllers.MathCalculations
{
    [Route("api/math/[action]")]
    [ApiController]
    public class MathCalculationsController : ControllerBase
    {
        private readonly IMathCalculator mathCalculator;
        private CalculationResultModel results;

        public MathCalculationsController(IMathCalculator mathCalculator)
        {
            this.mathCalculator = mathCalculator;
        }

        // GET: api/math/Distance
        [HttpGet]
        public IActionResult Distance(int x1, int y1, int x2, int y2)
        {
            try
            {
                results = mathCalculator.Distance(new List<int> { x1, y1 }, new List<int> { x2, y2 });

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST: api/math/Mean
        [HttpPost]
        public IActionResult Mean([FromBody] List<double> list)
        {
            try
            {
                results = mathCalculator.Mean(list);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/math/MidPoint
        [HttpGet]
        public IActionResult MidPoint(int x1, int y1, int x2, int y2)
        {
            try
            {
                results = mathCalculator.MidPoint(new List<int> { x1, y1 }, new List<int> { x2, y2 });

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/math/Probability
        [HttpGet]
        public IActionResult Probability(int targetOutcomes, int totalOutcomes)
        {
            try
            {
                results = mathCalculator.Probability(targetOutcomes, totalOutcomes);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/math/Slope
        [HttpGet]
        public IActionResult Slope(int x1, int y1, int x2, int y2)
        {
            try
            {
                results = mathCalculator.Slope(new List<int> { x1, y1 }, new List<int> { x2, y2 });

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/math/SlopeIntercept
        [HttpGet]
        public IActionResult SlopeIntercept(int x1, int y1, int slope)
        {
            try
            {
                results = mathCalculator.SlopeIntercept(new List<int> { x1, y1 }, slope);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
