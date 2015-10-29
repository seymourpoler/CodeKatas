using System.Collections.Generic;
using TripServiceKata.Exception;
using TripServiceKata.User;
using System.Linq;

namespace TripServiceKata.Trip
{
    public class TripService
    {
		private readonly UserSession userSession;
		private readonly TripDAO tripDao;

		public TripService()
		{
		}

		public TripService(UserSession userSession, TripDAO tripDao)
		{
			this.userSession = userSession;
			this.tripDao = tripDao;
		}

        public List<Trip> GetTripsByUser(User.User user)
        {
			var loggedUser = GetLoggedUser();
			return FindtripsByFriendsOf (user, loggedUser);
        }

		private User.User GetLoggedUser ()
		{
			var loggedUser = userSession.GetLoggedUser();
			if (loggedUser == null) 
			{
				throw new UserNotLoggedInException();
			}
			return loggedUser;
		}

		private List<Trip> FindtripsByFriendsOf(User.User user, User.User loggedUser)
		{
			foreach(User.User friend in user.GetFriends())			
			{
				if (friend.Equals(loggedUser))
				{
					return tripDao.FindTripsByUser(user);
				}
			}
			return NoTrips ();
		}

		private List<Trip> NoTrips()
		{
			return new List<Trip>();
		}
	}
}
