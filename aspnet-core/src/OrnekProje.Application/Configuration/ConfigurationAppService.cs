using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OrnekProje.Configuration.Dto;

namespace OrnekProje.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OrnekProjeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
