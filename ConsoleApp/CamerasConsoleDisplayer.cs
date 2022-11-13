using Domain;

namespace ConsoleApp
{
    public static class CamerasConsoleDisplayer
    {
        public static void DisplayCamerasInConsole(List<Camera> cameras)
        {
            foreach (Camera cam in cameras)
            {
                Console.WriteLine($"{cam.Id} | {cam.Name} | {cam.Latitude} | {cam.Longitude}");
            }
        }
    }
}
