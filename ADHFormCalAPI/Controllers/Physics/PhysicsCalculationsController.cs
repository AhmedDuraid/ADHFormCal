using ADHFormCalAPI.Calculator.Physics;
using ADHFormCalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ADHFormCalAPI.Controllers.Physics
{
    [Route("api/Physics/[action]")]
    [ApiController]
    public class PhysicsCalculationsController : ControllerBase
    {
        private CalculationResultModel results;
        private readonly IPhysicsCalculator physicsCalculator;

        public PhysicsCalculationsController(IPhysicsCalculator physicsCalculator)
        {
            this.physicsCalculator = physicsCalculator;
        }


        // GET: api/Physics/AverageSpeed_Distance
        [HttpGet]
        public IActionResult AverageSpeed_Distance(double aVGSpeed, double aVGtime)
        {
            try
            {
                results = physicsCalculator.AverageSpeed_Distance(aVGSpeed, aVGtime);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/AverageSpeed_Speed
        [HttpGet]
        public IActionResult AverageSpeed_Speed(double aVGdistance, double aVGtime)
        {
            try
            {
                results = physicsCalculator.AverageSpeed_Speed(aVGdistance, aVGtime);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/AverageSpeed_Time
        [HttpGet]
        public IActionResult AverageSpeed_Time(double aVGSpeed, double aVGtime)
        {
            try
            {
                results = physicsCalculator.AverageSpeed_Time(aVGSpeed, aVGtime);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/ChangeInTemperature
        [HttpGet]
        public IActionResult ChangeInTemperature(double initialTemperature, double finalTemperature)
        {
            try
            {
                results = physicsCalculator.ChangeInTemperature(initialTemperature, finalTemperature);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Density
        [HttpGet]
        public IActionResult Density(double mass, double volume)
        {
            try
            {
                results = physicsCalculator.Density(mass, volume);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Density_Mass
        [HttpGet]
        public IActionResult Density_Mass(double density, double volume)
        {
            try
            {
                results = physicsCalculator.Density_Mass(density, volume);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Density_Volume
        [HttpGet]
        public IActionResult Density_Volume(double density, double mass)
        {
            try
            {
                results = physicsCalculator.Density_Volume(density, mass);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Heat_ChangeOfTemperature
        [HttpGet]
        public IActionResult Heat_ChangeOfTemperature(double energy, double mass, double heat)
        {
            try
            {
                results = physicsCalculator.Heat_ChangeOfTemperature(energy, mass, heat);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Heat_Energy
        [HttpGet]
        public IActionResult Heat_Energy(double mass, double heat, double aVATemperature)
        {
            try
            {
                results = physicsCalculator.Heat_Energy(mass, heat, aVATemperature);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Heat_HeatCapacity
        [HttpGet]
        public IActionResult Heat_HeatCapacity(double energy, double mass, double aVATemperature)
        {
            try
            {
                results = physicsCalculator.Heat_HeatCapacity(energy, mass, aVATemperature);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Heat_Mass
        [HttpGet]
        public IActionResult Heat_Mass(double energy, double heat, double aVATemperature)
        {
            try
            {
                results = physicsCalculator.Heat_Mass(energy, heat, aVATemperature);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Ohm_Current
        [HttpGet]
        public IActionResult Ohm_Current(double voltage, double resistance)
        {
            try
            {
                results = physicsCalculator.Ohm_Current(voltage, resistance);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Ohm_Resistance
        [HttpGet]
        public IActionResult Ohm_Resistance(double voltage, double current)
        {
            try
            {
                results = physicsCalculator.Ohm_Resistance(voltage, current);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET: api/Physics/Ohm_VoltageCalculation
        [HttpGet]
        public IActionResult Ohm_VoltageCalculation(double current, double resistance)
        {
            try
            {
                results = physicsCalculator.Ohm_VoltageCalculation(current, resistance);

                return Ok(results);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
