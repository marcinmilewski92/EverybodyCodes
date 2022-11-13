using Domain;
using everybody_codes.Contracts;
using Microsoft.AspNetCore.Mvc;
using Services;

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
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<Camera>> Cameras()
        {
            var cameras = _cameraDataReader.GetAllCameras();
            if (cameras == null) { 

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(cameras);
        }

    }
}
