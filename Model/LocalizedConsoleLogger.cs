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
        /// <summary>
        /// Represents the default language key used for localization within the logger.
        /// It allows developers to set a default language for log messages, ensuring a consistent localization approach
        /// across the application.
        /// </summary>
        public LangKey LoggerLanguage { get; set; }
        /// <summary>
        /// Denotes the specialized service responsible for handling the localization process and resolving localized strings.
        /// </summary>
        public ILocalizator Localizator { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedConsoleLogger"/> class with the specified localization service.
        /// </summary>
        /// <param name="localizator">Localization service that provides localized resources.</param>
        public LocalizedConsoleLogger(ILocalizator localizator) => Localizator = localizator;

        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, with provided formatting rule <paramref name="logType"/>.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="logType">Log type. Defines formatting rules.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LLog(string mesKey, LogType logType = LogType.Message, bool standsAlone = true, params string?[] format)
            => Log(Localizator.ResolveString(LoggerLanguage, mesKey, format), logType, standsAlone);

        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Error"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LError(string mesKey, bool standsAlone = true, params string?[] format)
            => Error(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Warning"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LWarn(string mesKey, bool standsAlone = true, params string?[] format)
            => Warn(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Successful"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSuccess(string mesKey, bool standsAlone = true, params string?[] format)
            => Success(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.System"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSystem(string mesKey, bool standsAlone = true, params string?[] format)
            => System(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Information"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LInform(string mesKey, bool standsAlone = true, params string?[] format)
            => Inform(Localizator.ResolveString(LoggerLanguage, mesKey, format), standsAlone);
    }
}