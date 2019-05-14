using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Psy.Configuration;
using Psy.Web;

namespace Psy.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PsyDbContextFactory : IDesignTimeDbContextFactory<PsyDbContext>
    {
        public PsyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PsyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PsyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PsyConsts.ConnectionStringName));

            return new PsyDbContext(builder.Options);
        }
    }
}
