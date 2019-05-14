using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Psy.EntityFrameworkCore
{
    public static class PsyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PsyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PsyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
