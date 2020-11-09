using DesafioLocaliza.API.Services;
using DesafioLocaliza.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesafioLocaliza.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoDivisoresController : ControllerBase
    {


        [HttpPost]
        public async Task<IActionResult> Get([FromServices] CalculoDivisoresService CalculoDivisoresService, [FromBody] CalculoDivisoresRequestViewModel calculoDivisoresViewModel)
        {
            try
            {
                var result = CalculoDivisoresService.CalculaDivisoresNumeroInformado(calculoDivisoresViewModel);
                return Ok(result);
            }
            catch (System.Exception e)
            {
                return UnprocessableEntity(e.Message);
            }
        }
    }
}
