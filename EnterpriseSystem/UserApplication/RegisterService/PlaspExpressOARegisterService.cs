using Microsoft.Extensions.DependencyInjection;
using UserApplication.Services;
using UserDomain.Contexts;
using UserDomainContract.ServerContract.IApplicationServices;
using UserDomainContract.ServerContract.IRepository;
using UserRepository;

namespace UserApplication.RegisterService
{
    public class PlaspExpressOARegisterService
    {
        public static void RegisterService(IServiceCollection services)
        {
            // DbContext
            services.AddScoped<UserDbContext>();

            // Repository
            services.AddScoped<IUserInfoRepository, UserInfoRepository>();

            // Service
            services.AddScoped<IUserService, UserService>();
        }
    }
}
