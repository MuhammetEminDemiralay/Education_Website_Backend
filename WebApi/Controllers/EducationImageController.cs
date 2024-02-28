using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationImageController : ControllerBase
    {
        IEducationImageService _educationImageService;

        public EducationImageController(IEducationImageService educationImageService)
        {
            _educationImageService = educationImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _educationImageService.GetAll();
            if (result.Success)
            {
                Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int educationId)
        {
            var result = _educationImageService.Get(educationId);
            if (result.Success)
            { 
                Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile[] file, [FromForm] EducationImage educationImage)
        {
            var result = _educationImageService.AddCollection(file, educationImage);
            if (result.Success)
            {
               return  Ok(result);
            }

            return BadRequest();
        }

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _educationImageService.GetAll();
        //    if (result.Success)
        //    {
        //        Ok(result);
        //    }

        //    return BadRequest();
        //}

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _educationImageService.GetAll();
        //    if (result.Success)
        //    {
        //        Ok(result);
        //    }

        //    return BadRequest();
        //}
    }
}
