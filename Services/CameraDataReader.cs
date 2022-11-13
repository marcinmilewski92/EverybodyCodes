using everybody_codes.Contracts;
using Domain;
using System.Reflection;

namespace Services
{
    public class CameraDataReader : ICameraDataReader
    {
        private readonly string path = @"C:\Users\Marcin\Desktop\Project\EverybodyCodes\everybody-codes\data\cameras-defb.csv";
        private readonly string signature = "UTR-CM-";
        public List<Camera> GetAllCameras()
        {
            var cameras = new List<Camera>();
            List<string> lines;

            if(!File.Exists(path))
            {
                return null!; 
            }

            lines = File.ReadAllLines(path).ToList();
            lines.RemoveAt(0);

            foreach(string line in lines)
            {
                if(line.ToUpper().Contains("ERROR") || !line.Contains(';'))
                {
                    continue;
                }

                string[] cameraFields = line.Split(';');

                
                if(!int.TryParse(cameraFields[0].AsSpan(signature.Length, 3), out int id)) {
                    id = 0;
                }

                cameras.Add(new Camera()
                {
                    Id = id,
                    Name = cameraFields[0],
                    Latitude = cameraFields[1],
                    Longitude = cameraFields[2],
                });
            }

            return cameras;

        }
    }
}
