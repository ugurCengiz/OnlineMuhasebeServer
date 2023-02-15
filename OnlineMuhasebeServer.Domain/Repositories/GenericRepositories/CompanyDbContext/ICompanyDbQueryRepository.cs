using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepository.CompanyDbContext
{
    public interface ICompanyDbQueryRepository<T> : ICompanyDbRepository<T>,IQueryGenericRepository<T>
        where T : Entity
    {
      
    }
}
