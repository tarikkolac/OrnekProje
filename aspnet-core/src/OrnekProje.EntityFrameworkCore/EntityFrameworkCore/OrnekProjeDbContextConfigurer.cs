using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OrnekProje.EntityFrameworkCore
{
    public static class OrnekProjeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OrnekProjeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OrnekProjeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
