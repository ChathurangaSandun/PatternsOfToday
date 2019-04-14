using Factory.Models;

namespace Factory.Services
{
    public class UserService : IUserService
    {
        public User Get()
        {
            return new User { MembershipType = MembershipType.Gold };
        }
    }
}
