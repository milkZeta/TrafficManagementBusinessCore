using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TrafficManagementBusinessCore.Configuration.Dto;

namespace TrafficManagementBusinessCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TrafficManagementBusinessCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
