using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepository.AppDbContext;

namespace OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyQueryRepository:IAppQueryRepository<Company>
    {
    }
}
