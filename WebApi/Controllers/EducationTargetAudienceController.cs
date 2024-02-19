using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationTargetAudienceController : ControllerBase
    {
        IEducationTargetAudienceService _targetAudienceService;

        public EducationTargetAudienceController(IEducationTargetAudienceService targetAudienceService)
        {
            _targetAudienceService = targetAudienceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _targetAudienceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int targetAudienceId)
        {
            var result = _targetAudienceService.Get(targetAudienceId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(EducationTargetAudience educationTargetAudience)
        {
            var result = _targetAudienceService.Add(educationTargetAudience);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(EducationTargetAudience educationTargetAudience)
        {
            var result = _targetAudienceService.Update(educationTargetAudience);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationTargetAudience educationTargetAudience)
        {
            var result = _targetAudienceService.Delete(educationTargetAudience);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
