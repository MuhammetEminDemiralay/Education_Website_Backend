using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationRequirementController : ControllerBase
    {
        IEducationRequirementService _requirementService;

        public EducationRequirementController(IEducationRequirementService requirementService)
        {
            _requirementService = requirementService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _requirementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int requirementId)
        {
            var result = _requirementService.Get(requirementId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(EducationRequirement educationRequirement)
        {
            var result = _requirementService.Add(educationRequirement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(EducationRequirement educationRequirement)
        {
            var result = _requirementService.Update(educationRequirement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationRequirement educationRequirement)
        {
            var result = _requirementService.Delete(educationRequirement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
