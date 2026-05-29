namespace BookStore.Models
{
	public class CartItem
	{
		#region Properties
		public int UserId { get; set; }
		public int BookId { get; set; }
		public int Quantity { get; set; }
		#endregion
	}
}
