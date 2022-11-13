using Domain;
using everybody_codes.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        private readonly ICameraDataReader _cameraDataReader;

        public CameraController(ICameraDataReader cameraDataReader)
        {
            this._cameraDataReader = cameraDataReader;
        }

        // GET: api/<CameraController>
        [HttpGet]
        public IEnumerable<Camera> Get()
        {
            return _cameraDataReader.GetAllCameras();
        }

    }
}
