using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Psy.Configuration.Dto;

namespace Psy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PsyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
