using BookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrderController : ControllerBase
	{
		#region Fields
		private readonly PaymentService _paymentService;
		#endregion

		#region Constructors
		public OrderController(PaymentService paymentService)
		{
			_paymentService = paymentService;
		}
		#endregion

		#region Publics
		[HttpPost]
		public IActionResult PlaceOrder()
		{
			try
			{
				var paymentSuccess = _paymentService.ProcessPayment();

				return Ok(new { Message = "Order placed successfully" });
			}
			catch(Exception ex)
			{
				return StatusCode(500, new { Message = "Entire operation failed", Error = ex.Message });
			}
		}
		#endregion
	}
}