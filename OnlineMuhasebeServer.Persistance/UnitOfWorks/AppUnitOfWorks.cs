using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance.UnitOfWorks
{
    public sealed class AppUnitOfWorks:IAppUnitOfWork
    {

        private readonly AppDbContext _context;

        public AppUnitOfWorks(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken =default)
        {
          int count =  await _context.SaveChangesAsync(cancellationToken);
          return count;
        }
    }
}
