using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrnekProje.Authorization;

namespace OrnekProje
{
    [DependsOn(
        typeof(OrnekProjeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OrnekProjeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OrnekProjeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OrnekProjeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
