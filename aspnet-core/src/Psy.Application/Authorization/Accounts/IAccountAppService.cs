using System.Threading.Tasks;
using Abp.Application.Services;
using Psy.Authorization.Accounts.Dto;

namespace Psy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
