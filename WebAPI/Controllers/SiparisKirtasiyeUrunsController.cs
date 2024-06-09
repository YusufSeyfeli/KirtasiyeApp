using Business.Repositories.SiparisKirtasiyeUrunRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisKirtasiyeUrunsController : ControllerBase
    {
        private readonly ISiparisKirtasiyeUrunService _siparisKirtasiyeUrunService;

        public SiparisKirtasiyeUrunsController(ISiparisKirtasiyeUrunService siparisKirtasiyeUrunService)
        {
            _siparisKirtasiyeUrunService = siparisKirtasiyeUrunService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(SiparisKirtasiyeUrun siparisKirtasiyeUrun)
        {
            var result = await _siparisKirtasiyeUrunService.Add(siparisKirtasiyeUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(SiparisKirtasiyeUrun siparisKirtasiyeUrun)
        {
            var result = await _siparisKirtasiyeUrunService.Update(siparisKirtasiyeUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(SiparisKirtasiyeUrun siparisKirtasiyeUrun)
        {
            var result = await _siparisKirtasiyeUrunService.Delete(siparisKirtasiyeUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _siparisKirtasiyeUrunService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _siparisKirtasiyeUrunService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
