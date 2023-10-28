using System.Threading.Tasks;
using OrnekProje.Configuration.Dto;

namespace OrnekProje.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
