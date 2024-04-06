using SKitLs.Utils.Localizations.Languages;
using SKitLs.Utils.Localizations.Localizators;
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
    /// <remarks>
    /// Initializes a new instance of the <see cref="LocalizedConsoleLogger"/> class with the specified localization service.
    /// </remarks>
    /// <param name="localizator">Localization service that provides localized resources.</param>
    /// <param name="resolveDefault">Specifies whether to attempt resolving the string in the default language if not found in the specified language.</param>
    public class LocalizedConsoleLogger(ILocalizator localizator, bool resolveDefault = true) : DefaultConsoleLogger, ILocalizedLogger
    {
        /// <summary>
        /// Gets or sets a value indicating whether to attempt resolving the string in the default language if not found in the specified language.
        /// </summary>
        public bool ResolveDefaultLanguage { get; set; } = resolveDefault;

        /// <inheritdoc/>
        public LanguageCode LoggerLanguage { get; set; }

        /// <inheritdoc/>
        public ILocalizator Localizator { get; private set; } = localizator;

        /// <inheritdoc/>
        public void LLog(string mesKey, LogType logType = LogType.Message, bool standsAlone = true, params string?[] format)
            => Log(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), logType, standsAlone);

        /// <inheritdoc/>
        public void LError(string mesKey, bool standsAlone = true, params string?[] format)
            => Error(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), standsAlone);

        /// <inheritdoc/>
        public void LWarn(string mesKey, bool standsAlone = true, params string?[] format)
            => Warn(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), standsAlone);

        /// <inheritdoc/>
        public void LSuccess(string mesKey, bool standsAlone = true, params string?[] format)
            => Success(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), standsAlone);

        /// <inheritdoc/>
        public void LSystem(string mesKey, bool standsAlone = true, params string?[] format)
            => System(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), standsAlone);

        /// <inheritdoc/>
        public void LInform(string mesKey, bool standsAlone = true, params string?[] format)
            => Inform(Localizator.ResolveStringOrFallback(LoggerLanguage, mesKey, ResolveDefaultLanguage, format), standsAlone);
    }
}