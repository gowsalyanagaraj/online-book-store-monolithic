namespace BookStore.Services
{
	public class PaymentService
	{
		#region Publics
		public bool ProcessPayment()
		{
			throw new Exception("Payment gateway down");
			//return true;
		}
		#endregion
	}
}