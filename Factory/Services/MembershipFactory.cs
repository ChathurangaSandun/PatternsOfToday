using Factory.Models;
using System;
using Factory.Services.Memberships;

namespace Factory.Services
{
    public class MembershipFactory : IMembershipFactory
    {
        private readonly Func<FreeMembership> _free;
        private readonly Func<BronzeMembership> _bronze;
        private readonly Func<SilverMembership> _silver;
        private readonly Func<GoldMembership> _gold;

        public MembershipFactory(
            Func<FreeMembership> free,
            Func<BronzeMembership> bronze,
            Func<SilverMembership> silver,
            Func<GoldMembership> gold)
        {
            _free = free;
            _bronze = bronze;
            _silver = silver;
            _gold = gold;
        }

        public IMembership Create(MembershipType type)
        {
            switch (type)
            {
                case MembershipType.Free:
                    return _free();
                case MembershipType.Bronze:
                    return _bronze();
                case MembershipType.Silver:
                    return _silver();
                case MembershipType.Gold:
                    return _gold();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
