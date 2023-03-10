using OnlineMuhasebeServer.Domain.CompanyEntities;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.CompanyDbContext;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.BookEntryRepositories;

namespace OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.BookEntryRepositories;

public class BookEntryQueryRepository : CompanyDbQueryRepository<BookEntry>, IBookEntryQueryRepository
{

}
