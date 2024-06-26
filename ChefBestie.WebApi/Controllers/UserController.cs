using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;
using ChefBestie.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.WebApi.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;

        public UserController(IUserService userService, IUserRepository userRepository)
        {
            _userService = userService;
            _userRepository =  userRepository;
        }              
        

        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("by-id")]
        public ActionResult GetById(int id)
        {
            return Ok(_userService.GetById(id));
        }

        [HttpPost("add-update")]
        public ActionResult Post(User user)
        {
            return Ok(_userService.Post(user));
        }

        [HttpDelete("by-id")]
        public void Remove(string name)
        {
            _userService.Remove(name);
        }
    }
}
