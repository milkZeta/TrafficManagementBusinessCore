using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TrafficManagementBusinessCore.Localization
{
    public static class TrafficManagementBusinessCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TrafficManagementBusinessCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TrafficManagementBusinessCoreLocalizationConfigurer).GetAssembly(),
                        "TrafficManagementBusinessCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
