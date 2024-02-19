using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationSummaryController : ControllerBase
    {
        IEducationSummaryService _summaryService;

        public EducationSummaryController(IEducationSummaryService summaryService)
        {
            _summaryService = summaryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _summaryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult Get(int summaryId)
        {
            var result = _summaryService.Get(summaryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(EducationSummary educationSummary)
        {
            var result = _summaryService.Add(educationSummary);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult Update(EducationSummary educationSummary)
        {
            var result = _summaryService.Update(educationSummary);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("delete")]
        public IActionResult Delete(EducationSummary educationSummary)
        {
            var result = _summaryService.Delete(educationSummary);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
