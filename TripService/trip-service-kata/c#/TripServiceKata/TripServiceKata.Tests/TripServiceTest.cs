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
		private TripService tripService;
		private Mock<UserSession> userSession;

		[SetUp]
		public void SetUp()
		{
			userSession = new Mock<UserSession> ();
			tripService = new TripService (userSession.Object);
		}


		[Test]
		[ExpectedException( typeof( UserNotLoggedInException ) )]
		public void ShouldReturnUserNotLoggedInExceptionWhenLoggedUserIsNull()
		{
			tripService.GetTripsByUser (new User ());

			Assert.Fail("UserNotLoggedInException expected");
		}

		[Test]
		public void ShoukldReturnEmptyTripListOfFriends()
		{
			userSession.Setup (x => x.GetLoggedUser()).Returns(new User());

			var tripsOfFiends = tripService.GetTripsByUser (new User ());

			Assert.IsEmpty (tripsOfFiends);
		}

		[Test]
		public void ShouldReturnEmptyTripListOfFriendsWhenLoggedUserIsNotTheFriend()
		{
			userSession.Setup (x => x.GetLoggedUser()).Returns(new User());
			var user = new Mock<User>();
			user.Setup (x => x.GetFriends()).Returns (new List<User> {new User(), new User()});

			var tripsOfFiends = tripService.GetTripsByUser (user.Object);

			Assert.IsEmpty (tripsOfFiends);
		}

		[Test]
		public void ShouldReturnTripsByLoggedUser()
		{
			var friend = new User ();
			userSession.Setup (x => x.GetLoggedUser()).Returns(friend);
			var user = new Mock<User>();
			user.Setup (x => x.GetFriends()).Returns (new List<User> {friend, friend});

			var tripsOfFiends = tripService.GetTripsByUser (user.Object);

			Assert.IsNotEmpty (tripsOfFiends);
		}
    }
}
