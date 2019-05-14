using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Psy.Roles.Dto;
using Psy.Users.Dto;

namespace Psy.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
