using SKitLs.Utils.Localizations.Languages;
using SKitLs.Utils.Localizations.Localizators;
using SKitLs.Utils.Loggers.Prototype;

namespace SKitLs.Utils.LocalLoggers.Model
{
    /// <summary>
    /// Provides a specialized mechanism for localizing log messages during the debugging process.
    /// This interface extends the <see cref="ILogger"/> interface, providing a set of methods that enable the incorporation
    /// of localized log messages seamlessly. Utilizes the <see cref="ILocalizator"/> service for localization mechanics.
    /// </summary>
    public interface ILocalizedLogger : ILogger
    {
        /// <summary>
        /// Gets the default language key used for localization within the logger.
        /// Allows developers to set a default language for log messages, ensuring a consistent localization approach across the application.
        /// </summary>
        public LanguageCode LoggerLanguage { get; }
        
        /// <summary>
        /// Gets the specialized service responsible for handling the localization process and resolving localized strings.
        /// </summary>
        public ILocalizator Localizator { get; }

        /// <summary>
        /// Logs a localized custom message, resolving it by its <paramref name="mesKey"/>, with the provided formatting rule <paramref name="logType"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="logType">The log type that defines the formatting rules.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LLog(string mesKey, LogType logType = LogType.Message, bool standsAlone = true, params string?[] format);

        /// <summary>
        /// Logs a localized custom message as an <see cref="LogType.Error"/> message, resolving it by its <paramref name="mesKey"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LError(string mesKey, bool standsAlone = true, params string?[] format);

        /// <summary>
        /// Logs a localized custom message as a <see cref="LogType.Warning"/> message, resolving it by its <paramref name="mesKey"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LWarn(string mesKey, bool standsAlone = true, params string?[] format);

        /// <summary>
        /// Logs a localized custom message as a <see cref="LogType.Successful"/> message, resolving it by its <paramref name="mesKey"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSuccess(string mesKey, bool standsAlone = true, params string?[] format);

        /// <summary>
        /// Logs a localized custom message as a <see cref="LogType.System"/> message, resolving it by its <paramref name="mesKey"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LSystem(string mesKey, bool standsAlone = true, params string?[] format);

        /// <summary>
        /// Logs a localized custom message as an <see cref="LogType.Information"/> message, resolving it by its <paramref name="mesKey"/>.
        /// </summary>
        /// <param name="mesKey">The message key used to resolve and log the message.</param>
        /// <param name="standsAlone">Determines whether the message should be logged as a standalone one (e.g., NewLine for Console).</param>
        /// <param name="format">Optional. An array of strings to be formatted into the resolved localized string.</param>
        public void LInform(string mesKey, bool standsAlone = true, params string?[] format);
    }
}