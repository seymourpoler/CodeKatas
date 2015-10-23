namespace TripServiceKata.Tests
{
	using NUnit.Framework;
	using TripServiceKata.Trip;
	using TripServiceKata.User;

	[TestFixture]
    public class TripServiceTest
    {
		[Test]
		public void pp()
		{
			var service = new TripService ();
			var result = service.GetTripsByUser (new User ());

			Assert.IsNotNull (result);
		}
    }
}
