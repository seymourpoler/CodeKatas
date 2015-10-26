using System.Collections.Generic;
using TripServiceKata.Exception;
using TripServiceKata.User;

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
            User.User loggedUser = userSession.GetLoggedUser();

            if (loggedUser != null)
            {
                foreach(User.User friend in user.GetFriends())
                {
                    if (friend.Equals(loggedUser))
                    {
						return tripDao.FindTripsByUser(user);
                    }
                }
				return new List<Trip>();
            }
            else
            {
                throw new UserNotLoggedInException();
            }
        }
    }
}
