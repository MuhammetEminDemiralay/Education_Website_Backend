using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationVideoController : ControllerBase
    {
        IEducationVideoService _educationVideoService;

        public EducationVideoController(IEducationVideoService educationVideoService)
        {
            _educationVideoService = educationVideoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _educationVideoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int educationVideoId)
        {
            var result = _educationVideoService.Get(educationVideoId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile[] files, EducationVideo educationVideo)
        {
            var result = _educationVideoService.AddCollection(files, educationVideo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }


        //[HttpGet("update")]
        //public IActionResult Get(int educationVideoId)
        //{
        //    var result = _educationVideoService.Get(educationVideoId);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest();
        //}


        //[HttpGet("get")]
        //public IActionResult Get(int educationVideoId)
        //{
        //    var result = _educationVideoService.Get(educationVideoId);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest();
        //}


    }
}
