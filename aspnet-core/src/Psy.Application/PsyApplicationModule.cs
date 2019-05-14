using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Psy.Authorization;

namespace Psy
{
    [DependsOn(
        typeof(PsyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PsyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PsyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PsyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
