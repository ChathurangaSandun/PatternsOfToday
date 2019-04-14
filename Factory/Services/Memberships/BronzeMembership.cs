using Factory.Models;

namespace Factory.Services.Memberships
{
    public class BronzeMembership : IMembership
    {
        public Discount GetDiscount()
        {
            return new Discount
            {
                MembershipStatus = "Bronze Member",
                NewItemRate = 0.95,
                UsedItemRate = 0.85
            };
        }
    }
}
