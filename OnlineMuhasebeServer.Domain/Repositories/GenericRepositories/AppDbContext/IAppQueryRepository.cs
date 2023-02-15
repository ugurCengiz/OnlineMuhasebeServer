using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepository.AppDbContext
{
    public interface IAppQueryRepository<T>:IQueryGenericRepository<T>,IRepository<T> where T:Entity
    {

    }
}
