using Business.Abstracts;
using Business.Dtos.DutyDtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DutyController : ControllerBase
    {
        private readonly IDutyService _dutyService;

        public DutyController(IDutyService dutyService)
        {
            _dutyService = dutyService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(DutyCreateRequest request)
        {

            return Ok(await _dutyService.AddAync(request));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(DutyDeleteRequest request)
        {
            return Ok(await _dutyService.DeleteAsync(request));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _dutyService.GetByIdAsync(id));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _dutyService.GetAllAsync());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(DutyUpdateRequest request)
        {
            return Ok(await _dutyService.UpdateAsync(request));
        }
    }
}
