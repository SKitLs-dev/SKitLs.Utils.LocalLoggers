using SKitLs.Utils.Localizations.Prototype;
using SKitLs.Utils.Loggers.Prototype;

namespace SKitLs.Utils.LocalLoggers.Prototype
{
    /// <summary>
    /// <see cref="ILocalizedLogger"/> interface provides specialized mechanism for localizing strings during the debugging process.
    /// This interface extends the <see cref="ILogger"/> interface, providing a set of methods that enable to incorporate
    /// localized log messages seamlessly. Uses <see cref="ILocalizator"/> to provide mechanics.
    /// </summary>
    public interface ILocalizedLogger : ILogger
    {
        /// <summary>
        /// Represents the default language key used for localization within the logger.
        /// It allows developers to set a default language for log messages, ensuring a consistent localization approach
        /// across the application.
        /// </summary>
        public LangKey LoggerLanguage { get; }
        /// <summary>
        /// Denotes the specialized service responsible for handling the localization process and resolving localized strings.
        /// </summary>
        public ILocalizator Localizator { get; }

        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, with provided formatting rule <paramref name="logType"/>.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="logType">Log type. Defines formatting rules.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LLog(string mesKey, LogType logType = LogType.Message, bool standsAlone = true, params string?[] format);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Error"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LError(string mesKey, bool standsAlone = true, params string?[] format);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Warning"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LWarn(string mesKey, bool standsAlone = true, params string?[] format);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Successful"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSuccess(string mesKey, bool standsAlone = true, params string?[] format);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.System"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSystem(string mesKey, bool standsAlone = true, params string?[] format);
        /// <summary>
        /// Logs localized custom message, resolving it by its <paramref name="mesKey"/>, as <see cref="LogType.Information"/> one.
        /// </summary>
        /// <param name="mesKey">Message's key. Used to resolve message and log it.</param>
        /// <param name="standsAlone">Determines whether message should be logged as a stand-alone one
        /// (ex: NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LInform(string mesKey, bool standsAlone = true, params string?[] format);
    }
}