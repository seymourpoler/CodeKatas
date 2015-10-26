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
            List<Trip> tripList = new List<Trip>();
            User.User loggedUser = userSession.GetLoggedUser();
            bool isFriend = false;
            if (loggedUser != null)
            {
                foreach(User.User friend in user.GetFriends())
                {
                    if (friend.Equals(loggedUser))
                    {
                        isFriend = true;
                        break;
                    }
                }
                if (isFriend)
                {
                    tripList = tripDao.FindTripsByUser(user);
                }
                return tripList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }
        }
    }
}
