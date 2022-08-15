using Business.Abstract;
using Business.Configuration.Auth;
using DTO.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;


namespace HomeTrackingSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly TokenProvider token;
        public UserController(IUserService _userService, TokenProvider _token)
        {
            userService = _userService;
            token = _token;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                
                var data = userService.GetAll();
                return Ok(data);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Login(UserDto user)
        {
            try
            {

                var data = token.CreateToken(user);
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
                userService.GetById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpPost]
        public IActionResult AddUser(UserDto user)
        {
            try
            {
                if (user != null)
                {
                    userService.Add(user);
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
        public IActionResult UpdateUser(UserDto user)
        {
            try
            {
                if (user != null)
                {
                    userService.Update(user);
                    return Ok(user);
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
        public IActionResult DeleteUser(int Id)
        {
            try
            {
                var model = userService.GetById(Id);
                if (model != null)
                {
                    userService.Delete(model);
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
