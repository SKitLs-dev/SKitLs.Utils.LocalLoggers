# SKitLs.Utils.LocalLoggers

Offers an advanced logging system that streamlines the logging process and simplifies debugging by using localized debug messages.

## Description

The project incorporates the robust localization capabilities of the SKitLs.Utils.Localization project, empowering developers to
seamlessly translate and adapt strings for diverse language contexts.

1. `interface ILocalizedLogger`:

    By implementing the `ILocalizedLogger` interface, developers gain access to specialized localization services, enabling the logging of
    localized messages during the debugging process.

2. `class LocalizedConsoleLogger`

    With the integrated `LocalizedConsoleLogger`, developers can easily log messages of different types, including errors, warnings,
    successes, and system-related messages. 


The logging system ensures clarity and consistency in log outputs, enhancing the development workflow and
facilitating effective debugging.

## Setup

### Requirements

Before running the project, please ensure that you have the following dependencies installed and properly configured in your development environment.

- SKitLs.Utils.Localizations 2.0.0 or higher
- SKitLs.Utils.Loggers 1.2.1 or higher

### Installation

1. Using Terminal Command:
    
    To install the project using the terminal command, follow these steps:

    1. Open the terminal or command prompt.
    2. Run command:
    
    ```
    dotnet add package SKitLs.Utils.LocalLoggers
    ```

2. Using NuGet Packages Manager:

    To install the project using the NuGet Packages Manager, perform the following steps:

    1. Open your preferred Integrated Development Environment (IDE) that supports NuGet package management (e.g., Visual Studio).
    2. Create a new project or open an existing one.
    3. Select "Project" > "Manage NuGet Packages"
    4. In the "Browse" tab, search for the project package you want to install.
    5. Click on the "Install" button to add the selected package to your project.
    5. Follow any additional setup instructions or configurations provided in the project's documentation.

3. Downloading Source Code and Direct Linking:

    To install the project by downloading the source code and directly linking it to your project, adhere to the following steps:

    1. Visit the project repository on [GitHub](https://github.com/Sargeras02/SKitLs.Utils.LocalLoggers.git)
    2. Click on the "Code" button and select "Download ZIP" to download the project's source code as a zip archive.
    3. Extract the downloaded zip archive to the desired location on your local machine.
    4. Open your existing project or create a new one in your IDE.
    5. Add the downloaded project files to your solution using the "Add Existing Project" option in your IDE's solution explorer.
    6. Reference the project in your solution and ensure any required dependencies are resolved.
    7. Follow any additional setup or configuration instructions provided in the project's documentation.

Please note that each method may have specific requirements or configurations that need to be followed for successful installation.
Refer to the project's documentation for any additional steps or considerations.

## Usage

### Enhancing Console-Based Logging:

For Console-based projects, you can take advantage of the `LocalizedConsoleLogger : DefaultConsoleLogger` class:

1. Create locals JSON

    "path/to/locals/en.name.json"
    ```JSON
    {
        "local.KeyNotDefined": "String with a key {1} is not defined in language {0} ({2}). Format params: ",
        "error": "Error! {0}.",
        "welcome_message": "Welcome to the project!",
        "greeting": "Welcome, {0}!",
        "farewell_message": "See you soon!"
    }
    ```

2. Initialize the LocalizedConsoleLogger:

    ```C#
    ILocalizator localizator = new DefaultLocalizator("path/to/locals"); // "resources/locals" by default
    ILogger logger = new LocalizedConsoleLogger(localizator);
    ```

3. Logging Messages to the Console:

    ```C#
    logger.LLog("greeting", LogType.Info, "Mister Awesome");
    // -> [>] Welcome, Mister Awesome!
    logger.LWarn("welcome_message");
    // -> [!] Welcome to the project!
    logger.LError("error", "ErrorFormatMessage");
    // -> [X] Error! ErrorFormatMessage.

    // Still able to use DefaultConsoleLogger methods
    logger.Warn("welcome_message");
    // -> [!] welcome_message
    ```

### Customizing Logging Behavior:

If you need to customize the logging behavior based on your project's specific requirements,
implement the ILogger interface in a custom class:

1. Create a Custom Logger Class:

    ```C#
    public class CustomLocalLogger : ILocalizedLogger
    {
        // Implement the methods from the ILogger interface as per your custom logging needs.
        // Example: You can log messages to a file, database, or an external service.
    }
    ```
2. Initialize Your Custom Logger:

    ```C#
    ILogger logger = new CustomLogger(); // Use your custom logger to handle logging in your project.
    ```

3. Log Your Messages:

    ```C#
    logger.LLog("infokey", LogType.Info);
    logger.LWarn("warningkey");
    logger.LError("errorkey");
    ```

## Contributors

Currently, there are no contributors actively involved in this project.
However, our team is eager to welcome contributions from anyone interested in advancing the project's development.

We value every contribution and look forward to collaborating with individuals who share our vision and passion for this endeavor.
Your participation will be greatly appreciated in moving the project forward.

Thank you for considering contributing to our project.

## License

This project is distributed under the terms of the MIT License.

Copyright (C) Sargeras02 2023

## Developer contact

For any issues related to the project, please feel free to reach out to us through the project's GitHub page.
We welcome bug reports, feedback, and any other inquiries that can help us improve the project.

You can also contact the project owner directly via their GitHub profile at the following [link](https://github.com/Sargeras02).

Your collaboration and support are highly appreciated, and we will do our best to address any concerns or questions promptly and professionally.
Thank you for your interest in our project.

## Notes

This project is utilized by a larger and well-established project, which can be found at the following [link](https://github.com/Sargeras02/SKitLs.Bots.Telegram.git).

Thank you for choosing our solution for your needs, and we look forward to contributing to your project's success.
