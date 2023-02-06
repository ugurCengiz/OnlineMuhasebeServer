using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Persistance.Constans;

namespace OnlineMuhasebeServer.Persistance.Configurations
{
    public sealed class UCAFConfiguration:IEntityTypeConfiguration<UnitFromChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UnitFromChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UnitformChartOfAccounts);
            builder.HasKey(p => p.Id);
        }
    }
}
