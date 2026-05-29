using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
	[ApiController]
	[Route("api/books")]
	public class BookController : ControllerBase
	{
		#region Constants
		private static readonly List<Book> books = new()
		                                           {
			                                           new Book { Id = 1, Title = "The Silent Patient", Price = 500 }, 
			                                           new Book { Id = 2, Title = "The Housemaid", Price = 600 }
		                                           };
		#endregion

		#region Publics
		[HttpGet]
		public IActionResult GetBooks()
		{
			return Ok(books);
		}
		#endregion
	}

	
}