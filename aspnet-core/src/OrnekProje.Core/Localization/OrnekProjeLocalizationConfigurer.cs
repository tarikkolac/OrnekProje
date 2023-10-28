using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace OrnekProje.Localization
{
    public static class OrnekProjeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(OrnekProjeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(OrnekProjeLocalizationConfigurer).GetAssembly(),
                        "OrnekProje.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
