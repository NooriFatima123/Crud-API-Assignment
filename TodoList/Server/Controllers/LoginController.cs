using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Server.Database;
using TodoList.Shared;

namespace TodoList.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        readonly private TodoListDbContext _db;

        public LoginController(TodoListDbContext db)
        {
            _db = db;
        }


        [HttpPost("SignUp")]

        public IActionResult SignUp(UserDto userDto)
        {
            User user = new User();
            try
            {
                var exist = _db.Users.Where(x => x.Email == userDto.Email).FirstOrDefault();
                if (exist != null) { 
                    user.UserName = userDto.UserName;
                    user.Password = userDto.Password;
                    user.Email = userDto.Email;
                    user.CreatedOn = DateTime.Now;
                    user.ModifyOn = DateTime.Now;
                    user.IsDeleted = false;
                    _db.Users.Add(user);
                    _db.SaveChanges();
                    return Ok(user);
                }else
                {
                    return BadRequest("User Already Exist");
                }
            }catch (Exception ex) {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost("SignIn")]

        public IActionResult SignIn([FromBody] UserDto userDto)
        {
            User user = new User();
            try
            {
                var exist = _db.Users.Where(x => x.Email == userDto.Email&&x.Password==userDto.Password).FirstOrDefault();
                if (exist != null)
                {
                    return Ok(user);
                }
                else
                {
                    return NotFound("User Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
