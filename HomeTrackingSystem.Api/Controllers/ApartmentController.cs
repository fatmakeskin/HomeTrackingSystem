using Business.Abstract;
using DTO.Apertment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HomeTrackingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ApartmentController:ControllerBase
    {
        private readonly IApertmentService apertmentService;
        public ApartmentController(IApertmentService _apertmentService)
        {
            apertmentService = _apertmentService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var data = apertmentService.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                apertmentService.GetById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpPost]
        public IActionResult AddApertment(ApertmentDto aprt)
        {
            try
            {
                if (aprt != null)
                {
                    apertmentService.Add(aprt);
                    return Ok();
                }

                else
                    return BadRequest();
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult UpdateApertment(ApertmentDto aprt)
        {
            try
            {
                if (aprt != null)
                {
                    apertmentService.Update(aprt);
                    return Ok(aprt);
                }
                else
                    return BadRequest();
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteApertment(int Id)
        {
            try
            {
                var model = apertmentService.GetById(Id);
                if (model != null)
                {
                    apertmentService.Delete(model);
                    return Ok(model);
                }
                else
                    return BadRequest();

            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
