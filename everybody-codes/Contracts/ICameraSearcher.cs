using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace everybody_codes.Contracts
{
    public interface ICameraSearcher
    {
        public List<Camera> GetCamerasByString(List<Camera> cameras, string name);
    }
}
