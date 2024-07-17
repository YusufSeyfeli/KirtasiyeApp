using Business.Repositories.UrunlerRepository;
using Entities.Concrete;
using Entities.Dtos.UrunlerDtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlersController : ControllerBase
    {
        private readonly IUrunlerService _urunlerService;

        public UrunlersController(IUrunlerService urunlerService)
        {
            _urunlerService = urunlerService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(UrunlerDto urunlerDto)
        {
            var result = await _urunlerService.Add(urunlerDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(UrunlerUpdateDto urunlerUpdateDto)
        {
            var result = await _urunlerService.Update(urunlerUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("[action]/{urunId}")]
        public async Task<IActionResult> Delete(int urunId)
        {
            var result = await _urunlerService.Delete(urunId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _urunlerService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _urunlerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
