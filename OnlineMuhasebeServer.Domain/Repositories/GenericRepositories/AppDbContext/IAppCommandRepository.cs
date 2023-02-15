using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepository.AppDbContext
{
    public interface IAppCommandRepository<T>  : ICommandGenericRepository<T>,IRepository<T> where T : Entity
    {
       
    }
}

