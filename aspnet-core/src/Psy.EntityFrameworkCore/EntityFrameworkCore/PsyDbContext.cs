using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Psy.Authorization.Roles;
using Psy.Authorization.Users;
using Psy.MultiTenancy;

namespace Psy.EntityFrameworkCore
{
    public class PsyDbContext : AbpZeroDbContext<Tenant, Role, User, PsyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PsyDbContext(DbContextOptions<PsyDbContext> options)
            : base(options)
        {
        }
    }
}
