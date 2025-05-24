//using Api.DTOs;
//using Application.Services;
//using Infrastructure.Data;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [EnableCors("AllowFrontend")]
//    public class TestController : ControllerBase
//    {
//        private readonly HelperService _helperService;

//        public TestController(HelperService helperService)
//        {
//            _helperService = helperService;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetTest()
//        {
//            var result = await _helperService.GetAllAsync<TestDto>();
//            if (result == null || !result.Any())
//            {
//                return NotFound();
//            }
//            return Ok(result);
//        }
//        [HttpPost]
//        public async Task<IActionResult> CreateTest([FromBody] TestDto testDto)
//        {
//            if (testDto == null)
//            {
//                return BadRequest();
//            }

//            var success = await _helperService.CreateAsync(testDto);
//            if (!success)
//            {
//                return StatusCode(500, "A problem happened while handling your request.");
//            }

//            return CreatedAtAction(nameof(GetTest), new { id = testDto.Id }, testDto);
//        }
//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateTest(int id, [FromBody] TestDto testDto)
//        {
//            if (testDto == null)
//            {
//                return BadRequest();
//            }

//            var success = await _helperService.UpdateAsync(id, testDto);
//            if (!success)
//            {
//                return StatusCode(500, "A problem happened while handling your request.");
//            }

//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteTest(int id)
//        {
//            var success = await _helperService.DeleteAsync<TestDto>(id);
//            if (!success)
//            {
//                return StatusCode(500, "A problem happened while handling your request.");
//            }

//            return NoContent();
//        }
//    }
//}
