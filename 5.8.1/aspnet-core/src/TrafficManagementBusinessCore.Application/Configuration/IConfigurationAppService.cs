using System.Threading.Tasks;
using TrafficManagementBusinessCore.Configuration.Dto;

namespace TrafficManagementBusinessCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
