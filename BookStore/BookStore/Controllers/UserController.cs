using BookStore.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	[ApiController]
	[Route("api/users")]
	public class UserController : ControllerBase
	{
		private static readonly List<User> users = new()
		                                           {
			                                           new User { Id = 1, Email = "john@gmail.com", Password = "aaa" },
			                                           new User { Id = 2, Email = "alice@yahoo.com", Password = "aaa" },
			                                           new User { Id = 3, Email = "max@abc.in", Password = "aaa" }
		                                           };

		[HttpGet("userDetails")]
		public IActionResult GetUsers()
		{
			return Ok(users);
		}

		[HttpPost("login")]
		public IActionResult Login([FromBody] LoginRequest request)
		{
			var user = users.FirstOrDefault(u =>
				                                u.Email == request.Email &&
				                                u.Password == request.Password);

			if(user != null)
			{
				return Ok(new
				          {
					          Message = "User successfully logged in"
				          });
			}

			return Unauthorized(new
			                    {
				                    Message = "Invalid username or password"
			                    });
		}
	}
}
