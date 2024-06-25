using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rendimento.Pix.Domain;
using Rendimento.Pix.Domain.Response;
namespace Rendimento.Pix.Services.Interface
{
    public interface IRequisicaoAcessoServices
    {
        public Task<Domain.Response.AcessToken> Autenticacao(Domain.Request.AcessToken credencial);
    }
}
