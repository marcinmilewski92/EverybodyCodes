using Domain;
using everybody_codes.Contracts;

namespace Services
{
    public class CameraSearcher : ICameraSearcher
    {
        public List<Camera> GetCamerasByString(List<Camera> cameras, string name)
        {
            return cameras.FindAll(c => c.Name.Contains(name));
        }
    }
}
