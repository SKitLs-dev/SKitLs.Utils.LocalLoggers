using SKitLs.Utils.Localizations.Prototype;
using SKitLs.Utils.LocalLoggers.Prototype;
using SKitLs.Utils.Loggers.Model;
using SKitLs.Utils.Loggers.Prototype;

namespace SKitLs.Utils.LocalLoggers.Model
{
    /// <summary>
    /// <see cref="LocalizedConsoleLogger"/> class extends the <see cref="DefaultConsoleLogger"/> class and implements
    /// <see cref="ILocalizedLogger"/> interface, providing a comprehensive mechanism for localizing log messages
    /// during the debugging process.
    /// <para>
    /// By combining the functionalities of <see cref="DefaultConsoleLogger"/> with the capabilities of 
    /// <see cref="ILocalizedLogger"/> interface, this class enables to log localized messages efficiently in debugging scenarios.
    /// </para>
    /// </summary>
    public class LocalizedConsoleLogger : DefaultConsoleLogger, ILocalizedLogger
    {
        public LangKey LoggerLanguage { get; set; }
        public ILocalizator Localizator { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedConsoleLogger"/> class with the specified localization service.
        /// </summary>
        /// <param name="localizator">Localization service that provides localized resources.</param>
        public LocalizedConsoleLogger(ILocalizator localizator) => Localizator = localizator;

        public void LLog(string mesKey, LogType type = LogType.Message, bool standsAlone = true, params string?[] format)
            => Log(Localizator.ResolveString(LoggerLanguage, mesKey, format), type, standsAlone);

        public void LError(string mesKey, bool standsAlone = true, params string?[] format)
            => Error(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        public void LWarn(string mesKey, bool standsAlone = true, params string?[] format)
            => Warn(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        public void LSuccess(string mesKey, bool standsAlone = true, params string?[] format)
            => Success(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        public void LSystem(string mesKey, bool standsAlone = true, params string?[] format)
            => System(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        public void LInform(string mesKey, bool standsAlone = true, params string?[] format)
            => Inform(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
    }
}