using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.DAO
{
    public class AccountDAO
    {
        public User GetUserByUsernameAndPassword(string username, string pass)
        {
            User user = new User();

            MusicStoreContext musicStoreContext = new MusicStoreContext();
            if (username != null && pass != null)
            {
                user = (from p in musicStoreContext.Users where p.UserName == username && p.Password == pass select p).ToList().FirstOrDefault();
            }

            return user;
        }
    }
}
