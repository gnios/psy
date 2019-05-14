using System.Threading.Tasks;
using Psy.Configuration.Dto;

namespace Psy.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
