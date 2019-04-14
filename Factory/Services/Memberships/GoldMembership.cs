using Factory.Models;

namespace Factory.Services.Memberships
{
    public class GoldMembership : IMembership
    {
        public Discount GetDiscount()
        {
            return new Discount
            {
                MembershipStatus = "Gold Member",
                NewItemRate = 0.75,
                UsedItemRate = 0.5
            };
        }
    }
}
