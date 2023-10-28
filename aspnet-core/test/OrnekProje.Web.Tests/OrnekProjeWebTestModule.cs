using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrnekProje.EntityFrameworkCore;
using OrnekProje.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace OrnekProje.Web.Tests
{
    [DependsOn(
        typeof(OrnekProjeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OrnekProjeWebTestModule : AbpModule
    {
        public OrnekProjeWebTestModule(OrnekProjeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OrnekProjeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OrnekProjeWebMvcModule).Assembly);
        }
    }
}