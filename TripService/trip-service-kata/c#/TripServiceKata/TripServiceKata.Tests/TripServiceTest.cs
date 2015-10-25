namespace TripServiceKata.Tests
{
	using NUnit.Framework;
	using Moq;
	using TripServiceKata.Trip;
	using TripServiceKata.User;
	using TripServiceKata.Exception;
	using System.Collections.Generic;

	[TestFixture]
    public class TripServiceTest
    {
		[Test]
		[ExpectedException( typeof( UserNotLoggedInException ) )]
		public void ShouldReturnUserNotLoggedInExceptionWhenLoggedUserIsNull()
		{
			var userSession = new Mock<UserSession> ();
			var service = new TripService (userSession.Object);

			service.GetTripsByUser (new User ());

			Assert.Fail("UserNotLoggedInException expected");
		}

		[Test]
		public void ShoukldReturnEmptyTripListOfFriends()
		{
			var userSession = new Mock<UserSession> ();
			var service = new TripService (userSession.Object);
			userSession.Setup (x => x.GetLoggedUser()).Returns(new User());

			var tripsOfFiends = service.GetTripsByUser (new User ());

			Assert.IsEmpty (tripsOfFiends);
		}

		[Test]
		public void ShouldReturnEmptyTripListOfFriendsWhenLoggedUserIsNotTheFriend()
		{
			var userSession = new Mock<UserSession> ();
			var service = new TripService (userSession.Object);
			userSession.Setup (x => x.GetLoggedUser()).Returns(new User());
			var user = new Mock<User>();
			user.Setup (x => x.GetFriends()).Returns (new List<User> ());

			var tripsOfFiends = service.GetTripsByUser (user.Object);

			Assert.IsEmpty (tripsOfFiends);
		}
    }
}
