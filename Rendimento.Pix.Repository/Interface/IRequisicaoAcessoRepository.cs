using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento.Pix.Repository.Interface
{
    public interface IRequisicaoAcessoRepository
    {
        public void InserirRequisicao(Rendimento.Pix.Domain.Entidades.RequisicaoAcesso requiscao);
    }
}
