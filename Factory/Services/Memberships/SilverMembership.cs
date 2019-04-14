using Factory.Models;

namespace Factory.Services.Memberships
{
    public class SilverMembership : IMembership
    {
        public Discount GetDiscount()
        {
            return new Discount
            {
                MembershipStatus = "Silver Member",
                NewItemRate = 0.85,
                UsedItemRate = 0.75
            };
        }
    }
}
