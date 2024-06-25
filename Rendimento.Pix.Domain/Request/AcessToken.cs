using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento.Pix.Domain.Request
{
    public class AcessToken
    {
        public string Authorization { get; set; }
        public string client_id { get; set; }
        public string client_secret { get; set; }
        public string acess_token { get; set; }
        public string url { get; set; }

    }
}
