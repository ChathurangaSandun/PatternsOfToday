using Factory.Models;

namespace Factory.Services.Memberships
{
    public class FreeMembership : IMembership
    {
        public Discount GetDiscount()
        {
            return new Discount
            {
                MembershipStatus = "Free Member",
                NewItemRate = 1.0,
                UsedItemRate = 1.0
            };
        }
    }
}
