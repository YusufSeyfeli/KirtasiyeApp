using Business.Repositories.SiparisKirtasiyeRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisKirtasiyesController : ControllerBase
    {
        private readonly ISiparisKirtasiyeService _siparisKirtasiyeService;

        public SiparisKirtasiyesController(ISiparisKirtasiyeService siparisKirtasiyeService)
        {
            _siparisKirtasiyeService = siparisKirtasiyeService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(SiparisKirtasiye siparisKirtasiye)
        {
            var result = await _siparisKirtasiyeService.Add(siparisKirtasiye);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(SiparisKirtasiye siparisKirtasiye)
        {
            var result = await _siparisKirtasiyeService.Update(siparisKirtasiye);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(SiparisKirtasiye siparisKirtasiye)
        {
            var result = await _siparisKirtasiyeService.Delete(siparisKirtasiye);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _siparisKirtasiyeService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _siparisKirtasiyeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
