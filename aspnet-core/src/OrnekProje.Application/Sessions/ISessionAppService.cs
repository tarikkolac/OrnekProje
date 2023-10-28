using System.Threading.Tasks;
using Abp.Application.Services;
using OrnekProje.Sessions.Dto;

namespace OrnekProje.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
