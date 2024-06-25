using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento.Pix.Domain.Entidades
{
    public class RequisicaoAcesso
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string ClientId { get; set; }
        public DateTime Data { get; set; }
        public string Etapa { get; set; }
    }
}
