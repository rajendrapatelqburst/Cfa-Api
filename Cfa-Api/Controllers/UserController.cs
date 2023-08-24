using Business_Logic_Layer;
using Data_Access_Layer.Repository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cfa_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserBLL _userBLL;
        public UserController(UserBLL userBLL) 
        {
            _userBLL = userBLL;
        }

        [HttpGet]
        public async  Task<ActionResult<List<User>>> GetUsers()
        {
            return _userBLL.GetUsers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetUserbyId(int id)
        {
            var user = await _userBLL.GetUserbyId(id);
            return Ok(user);
        }
        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] UserModel userModel)
        {
            var _user = new User
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Password = userModel.Password
            };
              _userBLL.PostUser(_user);

            return CreatedAtAction(nameof(PostUser), _user);
        }
    }
}
