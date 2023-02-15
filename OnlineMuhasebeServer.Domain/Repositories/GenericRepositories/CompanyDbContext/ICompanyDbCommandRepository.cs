﻿using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepository.CompanyDbContext
{
    public interface ICompanyDbCommandRepository<T> : ICompanyDbRepository<T>,ICommandGenericRepository<T> where T :Entity
    {
       
    }
}
