using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepository.CompanyDbContext;

namespace OnlineMuhasebeServer.Domain.UCAFRepositories
{
    public interface IUCAFQueryRepository:ICompanyDbQueryRepository<UnitFromChartOfAccount>
    {
    }
}
