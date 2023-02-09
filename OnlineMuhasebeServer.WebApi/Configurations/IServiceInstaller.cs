namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public interface IServiceInstaller
    {
        void Installer(IServiceCollection services, IConfiguration configuration);
    }
}
