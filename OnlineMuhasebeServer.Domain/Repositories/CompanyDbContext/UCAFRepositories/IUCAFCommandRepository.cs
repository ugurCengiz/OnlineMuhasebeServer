﻿using OnlineMuhasebeServer.Domain.CompanyEntities;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepository.CompanyDbContext;

namespace OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories
{
    public interface IUCAFCommandRepository : ICompanyDbCommandRepository<UniformChartOfAccount>
    {
    }
}