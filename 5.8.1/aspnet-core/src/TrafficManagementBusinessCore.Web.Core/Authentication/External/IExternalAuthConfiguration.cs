using System.Collections.Generic;

namespace TrafficManagementBusinessCore.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
