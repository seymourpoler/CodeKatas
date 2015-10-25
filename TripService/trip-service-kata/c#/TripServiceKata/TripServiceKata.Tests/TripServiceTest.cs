namespace TripServiceKata.Tests
{
	using NUnit.Framework;
	using Moq;
	using TripServiceKata.Trip;
	using TripServiceKata.User;
	using TripServiceKata.Exception;

	[TestFixture]
    public class TripServiceTest
    {
		[Test]
		[ExpectedException( typeof( UserNotLoggedInException ) )]
		public void ShouldReturnUserNotLoggedInExceptionWhenLoggedUserIsNull()
		{
			var userSession = new Mock<UserSession> ();
			var service = new TripService (userSession.Object);
			var result = service.GetTripsByUser (new User ());

			Assert.IsNotNull (result);
		}
    }
}
