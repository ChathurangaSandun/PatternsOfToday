using Factory.Models;
using Factory.Services.Memberships;

namespace Factory.Services
{
    public interface IMembershipFactory
    {
        IMembership Create(MembershipType type);
    }
}
