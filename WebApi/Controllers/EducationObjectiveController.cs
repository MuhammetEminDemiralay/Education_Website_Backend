using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationObjectiveController : ControllerBase
    {
        IEducationObjectiveService _objectiveService;

        public EducationObjectiveController(IEducationObjectiveService objectiveService)
        {
            _objectiveService = objectiveService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _objectiveService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int objectiveId)
        {
            var result = _objectiveService.Get(objectiveId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(EducationObjective educationObjective)
        {
            var result = _objectiveService.Add(educationObjective);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(EducationObjective educationObjective)
        {
            var result = _objectiveService.Update(educationObjective);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationObjective educationObjective)
        {
            var result = _objectiveService.Delete(educationObjective);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
