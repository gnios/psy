using System.Threading.Tasks;
using Abp.Application.Services;
using Psy.Sessions.Dto;

namespace Psy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
