using Microsoft.AspNetCore.Mvc;
using System;
using OurTestApi.Interface;

namespace OurTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private INLogger _logger;
        private IUser _usersRepository;

        public UserController(INLogger logger, IUser usersRepository)
        {
            _logger = logger;
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Exception thrown here
                //throw new Exception("Exception thrown!");

                _logger.LogInfo("Get all the users");
                var users = _usersRepository.GetAllUsers();

                _logger.LogInfo($"{users.Count} users returned");
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
