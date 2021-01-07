using ADHFormCalAPI.Calculator.Pharmaceutical;
using ADHFormCalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace ADHFormCalAPI.Controllers.Pharmaceutical
{
    [Route("api/pharmaceutical/[action]")]
    [ApiController]
    public class PharmaceuticalCalculationsController : ControllerBase
    {
        private readonly IPharmaceuticalCalculations pharmaceuticalCalculations;
        private CalculationResultModel results;

        public PharmaceuticalCalculationsController(IPharmaceuticalCalculations pharmaceuticalCalculations)
        {
            this.pharmaceuticalCalculations = pharmaceuticalCalculations;
        }

        // GET: api/pharmaceutical/AgebasedChildDose
        [HttpGet]
        public IActionResult AgebasedChildDose(int childAge, int adultDose)
        {
            try
            {
                results = pharmaceuticalCalculations.AgebasedChildDose(childAge, adultDose);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/BSA
        [HttpGet]
        public IActionResult BSA(double height, double weight)
        {
            try
            {
                results = pharmaceuticalCalculations.BSA(height, weight);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/Density
        [HttpGet]
        public IActionResult Density(double weight, double volume)
        {
            try
            {
                results = pharmaceuticalCalculations.Density(weight, volume);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/ValueInProof
        [HttpGet]
        public IActionResult ValueInProof(double alcoholStrengt)
        {
            try
            {
                results = pharmaceuticalCalculations.ValueInProof(alcoholStrengt);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/Volume
        [HttpGet]
        public IActionResult Volume(double weight, double density)
        {
            try
            {
                results = pharmaceuticalCalculations.Volume(weight, density);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/Weight
        [HttpGet]
        public IActionResult Weight(double vloume, double density)
        {
            try
            {
                results = pharmaceuticalCalculations.Weight(vloume, density);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/pharmaceutical/WeightBasedChildDose
        [HttpGet]
        public IActionResult WeightBasedChildDose(double childBSA, double adultDose)
        {
            try
            {
                results = pharmaceuticalCalculations.WeightBasedChildDose(childBSA, adultDose);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
