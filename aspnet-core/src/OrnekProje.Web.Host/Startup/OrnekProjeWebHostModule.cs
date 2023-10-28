using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OrnekProje.Configuration;

namespace OrnekProje.Web.Host.Startup
{
    [DependsOn(
       typeof(OrnekProjeWebCoreModule))]
    public class OrnekProjeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OrnekProjeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OrnekProjeWebHostModule).GetAssembly());
        }
    }
}
