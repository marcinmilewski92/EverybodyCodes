using ConsoleApp;
using Services;


var camerasSearcher = new CameraSearcher();
var camerasDataReader = new CameraDataReader();
CamerasConsoleDisplayer.DisplayCamerasInConsole(camerasSearcher.GetCamerasByString(camerasDataReader.GetAllCameras(), string.Join(" ", args)));