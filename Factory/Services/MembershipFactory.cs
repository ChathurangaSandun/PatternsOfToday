using Factory.Models;
using System;
using Factory.Services.Memberships;

namespace Factory.Services
{
    public class MembershipFactory : IMembershipFactory
    {
        public IMembership Create(MembershipType type)
        {
            switch (type)
            {
                case MembershipType.Free:
                    return new FreeMembership();
                case MembershipType.Bronze:
                    return new BronzeMembership();
                case MembershipType.Silver:
                    return new SilverMembership();
                case MembershipType.Gold:
                    return new GoldMembership();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
