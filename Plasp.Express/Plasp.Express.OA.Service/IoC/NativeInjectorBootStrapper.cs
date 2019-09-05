using Microsoft.Extensions.DependencyInjection;
using UserApplication.RegisterService;

namespace Plasp.Express.OA.Service.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //UserDomain
            PlaspExpressOARegisterService.RegisterService(service);
        }
    }
}
