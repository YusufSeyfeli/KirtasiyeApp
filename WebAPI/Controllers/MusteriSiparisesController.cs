using Business.Repositories.MusteriSiparisRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusteriSiparisesController : ControllerBase
    {
        private readonly IMusteriSiparisService _musteriSiparisService;

        public MusteriSiparisesController(IMusteriSiparisService musteriSiparisService)
        {
            _musteriSiparisService = musteriSiparisService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(MusteriSiparis musteriSiparis)
        {
            var result = await _musteriSiparisService.Add(musteriSiparis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(MusteriSiparis musteriSiparis)
        {
            var result = await _musteriSiparisService.Update(musteriSiparis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(int musteriSiparis)
        {
            var result = await _musteriSiparisService.Delete(musteriSiparis);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _musteriSiparisService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _musteriSiparisService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
