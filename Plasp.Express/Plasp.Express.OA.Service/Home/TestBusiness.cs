using UserDomainContract.ServerContract.IApplicationServices;

namespace Plasp.Express.OA.Service.Home
{
    public class TestBusiness
    {
        private readonly IUserService UserService;
        public TestBusiness(IUserService userService)
        {
            UserService = userService;
        }

        public string GetNotive()
        {
            var user = UserService.GetUserById(2);

            return user.UserName;
        }
    }
}
