using Microsoft.AspNetCore.Mvc;
using Rendimento.Pix.Services.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rendimento.Pix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly Services.Interface.IRequisicaoAcessoServices _requisicaoAcessoServices;

        public AutenticacaoController(Services.Interface.IRequisicaoAcessoServices requisicaoAcessoServices) 
        {
            _requisicaoAcessoServices = requisicaoAcessoServices;
        }

        // POST api/<AutenticacaoController>
        [HttpPost("Autenticacao")]
        public async Task<IActionResult> Post([FromBody] Domain.Request.AcessToken data)
        {            
            return Ok(await _requisicaoAcessoServices.Autenticacao(data));

        }

    }
}
