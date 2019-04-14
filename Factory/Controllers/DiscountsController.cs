using System.Threading.Tasks;
using Factory.Services;
using Factory.Services.Memberships;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMembershipFactory _membershipFactory;

        public DiscountsController(IUserService userService, IMembershipFactory membershipFactory)
        {
            _userService = userService;
            _membershipFactory = membershipFactory;
        }

        // GET api/discounts
        [HttpGet]
        public ActionResult<IMembership> Get()
        {
            var user = _userService.Get();
            var membership = _membershipFactory.Create(user.MembershipType);
            
            return Ok(membership.GetDiscount());
        }
    }
}