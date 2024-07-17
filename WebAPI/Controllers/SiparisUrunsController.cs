using Business.Repositories.SiparisUrunRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisUrunsController : ControllerBase
    {
        private readonly ISiparisUrunService _siparisUrunService;

        public SiparisUrunsController(ISiparisUrunService siparisUrunService)
        {
            _siparisUrunService = siparisUrunService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Add(SiparisUrun siparisUrun)
        {
            var result = await _siparisUrunService.Add(siparisUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(SiparisUrun siparisUrun)
        {
            var result = await _siparisUrunService.Update(siparisUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(int siparisUrun)
        {
            var result = await _siparisUrunService.Delete(siparisUrun);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _siparisUrunService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _siparisUrunService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
