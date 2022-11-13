using ConsoleApp;
using Services;


var ccd = new CamerasConsoleDisplayer(new CameraSearcher(), new CameraDataReader());
ccd.DisplayCamerasInConsole(StringJoiner(args));

static string StringJoiner(string[] args) => string.Join(" ", args);

// I hadrdcoded absolute file path in Services.CameraDataReader because of problems with correct running both api and console.
// So if you want to check program change path into your local.

//I didn't implement dotnet tool (dotnet search). So if you want to run console app,
//just type in its directory: dotnet run <expressionYouAreLookingForInName> or set args in Visual Studio.
