using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	[ApiController]
	[Route("api/cart")]
	public class CartController : ControllerBase
	{
		#region Constants
		private static readonly List<CartItem> cart = new();
		#endregion

		#region Publics
		[HttpGet]
		public IActionResult GetCart()
		{
			return Ok(cart);
		}

		[HttpPost("add")]
		public IActionResult AddToCart([FromBody] CartItem item)
		{
			cart.Add(item);
			return Ok(new { Message = "Book added to cart" });
		}
		#endregion
	}
}