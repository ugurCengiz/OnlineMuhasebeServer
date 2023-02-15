using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepository.AppDbContext;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories
{
    public class CompanyQueryRepository :AppQueryRepository<Company>,ICompanyQueryRepository
    {
        public CompanyQueryRepository(Context.AppDbContext context) : base(context)
        {
        }
    }
}
