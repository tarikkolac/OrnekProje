using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OrnekProje.Authorization.Roles;
using OrnekProje.Authorization.Users;
using OrnekProje.MultiTenancy;

namespace OrnekProje.EntityFrameworkCore
{
    public class OrnekProjeDbContext : AbpZeroDbContext<Tenant, Role, User, OrnekProjeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OrnekProjeDbContext(DbContextOptions<OrnekProjeDbContext> options)
            : base(options)
        {
        }
    }
}
