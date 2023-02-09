using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Infrasturcture.Authentication;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class InfrustructureDIServiceInstaller:IServiceInstaller
    {
        public void Installer(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
