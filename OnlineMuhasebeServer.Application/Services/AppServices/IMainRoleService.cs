using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Services.AppServices
{
    public interface IMainRoleService
    {
        Task<MainRole> GetByTitleAndCompanyId(string title, string companyId, CancellationToken cancellationToken = default);
        Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);

        Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken);
        Task RemoveByIdAsync(string id);

        IQueryable<MainRole > GetAll();

        Task<MainRole> GetByIdAsync(string id);

        Task UpdateAsync(MainRole mainRole);
    }
}
