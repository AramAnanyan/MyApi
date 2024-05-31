using BLL.Services;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IEffectService effectService;
        public MyController(IEffectService effectService)
        {
            this.effectService = effectService;

        }
        [HttpPost]
        public async Task<IActionResult> AddEffect(GetEffectRequestModel model)
        {
            await effectService.AddAsync(model);
            return Created(string.Empty, null);
        }
        [HttpGet]
        public async Task<IActionResult> GetEffects([FromQuery] GetEffectRequestModel effect)
        {
            var effects = await effectService.GetAsync(effect);
            return Ok(effects);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetUserDetails(int id)
        {
            var effect = await effectService.GetDetailsAsync(id);
            return Ok(effect);
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(EditEffectRequestModel model)
        {
            await effectService.EditAsync(model);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await effectService.DeleteUserAsync(id);
            return Ok();
        }
    }

}
