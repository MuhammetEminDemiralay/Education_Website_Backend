using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationAchievementController : ControllerBase
    {
        IEducationAchievementService _achievementService;

        public EducationAchievementController(IEducationAchievementService achievementService)
        {
            _achievementService = achievementService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _achievementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int achievementId)
        {
            var result = _achievementService.Get(achievementId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(EducationAchievement educationAchievement)
        {
            var result = _achievementService.Add(educationAchievement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(EducationAchievement educationAchievement)
        {
            var result = _achievementService.Update(educationAchievement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationAchievement educationAchievement)
        {
            var result = _achievementService.Delete(educationAchievement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
