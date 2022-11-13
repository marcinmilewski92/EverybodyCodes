using Domain;
using everybody_codes.Contracts;

namespace ConsoleApp
{
    public class CamerasConsoleDisplayer
    {
        private readonly ICameraSearcher _cameraSearcher;
        private readonly ICameraDataReader _cameraDataReader;

        public CamerasConsoleDisplayer(
            ICameraSearcher cameraSearcher, 
            ICameraDataReader cameraDataReader)
        {
            this._cameraSearcher = cameraSearcher;
            this._cameraDataReader = cameraDataReader;
        }

        public void DisplayCamerasInConsole(string args)
        {

            var cameras = _cameraSearcher.GetCamerasByString(_cameraDataReader.GetAllCameras(), args);

            if (cameras == null)
            {
                Console.WriteLine("File doesn't exist");
            } 
            else
            {
                foreach (Camera cam in cameras)
                {
                    Console.WriteLine($"{cam.Id} | {cam.Name} | {cam.Latitude} | {cam.Longitude}");
                }
            }
        }


    }
}
