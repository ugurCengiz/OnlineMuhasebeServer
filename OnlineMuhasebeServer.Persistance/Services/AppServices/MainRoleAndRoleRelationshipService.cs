using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;

namespace OnlineMuhasebeServer.Persistance.Services.AppServices;

public class MainRoleAndRoleRelationshipService : IMainRoleAndRoleRelationshipService
{
    private readonly IMainRoleAndRoleRelationshipCommandRepository _andRoleRelationshipCommandRepository;
    private readonly IMainRoleAndRoleRelationshipQueryRepository _andRoleRelationshipQueryRepository;
    private readonly IAppUnitOfWork _appUnitOfWork;

    public MainRoleAndRoleRelationshipService(IMainRoleAndRoleRelationshipQueryRepository andRoleRelationshipQueryRepository, IMainRoleAndRoleRelationshipCommandRepository andRoleRelationshipCommandRepository, IAppUnitOfWork appUnitOfWork)
    {
        _andRoleRelationshipQueryRepository = andRoleRelationshipQueryRepository;
        _andRoleRelationshipCommandRepository = andRoleRelationshipCommandRepository;
        _appUnitOfWork = appUnitOfWork;
    }

    public async Task CreateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship, CancellationToken cancellationToken)
    {
        await _andRoleRelationshipCommandRepository.AddAsync(mainRoleAndRoleRelationship, cancellationToken);
        await _appUnitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(MainRoleAndRoleRelationship mainRoleAndRoleRelationship)
    {
        _andRoleRelationshipCommandRepository.Update(mainRoleAndRoleRelationship);
        await _appUnitOfWork.SaveChangesAsync();
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _andRoleRelationshipCommandRepository.RemoveById(id);
        await _appUnitOfWork.SaveChangesAsync();

    }

    public IQueryable<MainRoleAndRoleRelationship> GetAll()
    {
        return _andRoleRelationshipQueryRepository.GetAll();
    }

    public async Task<MainRoleAndRoleRelationship> GetByIdAsync(string id)
    {
        return await _andRoleRelationshipQueryRepository.GetById(id);

    }

    public async Task<MainRoleAndRoleRelationship> GetByRoleIdAndMainRoleId(string roleId, string mainRoleId,CancellationToken cancellationToken)
    {
        return await _andRoleRelationshipQueryRepository.GetFirstByExpiression(x =>
            x.RoleId == roleId && x.MainRoleId == mainRoleId,cancellationToken);
    }
}
