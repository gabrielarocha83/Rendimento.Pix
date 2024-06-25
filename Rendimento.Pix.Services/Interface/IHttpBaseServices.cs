using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rendimento.Pix.Services.Interface
{
    public interface IHttpBaseServices
    {
        Task<string> GetAsync(string url);

        Task<string> PostAsync(string url, HttpContent content);

        Task<string> PutAsync(string url, HttpContent content);

        Task<string> DeleteAsync(string url);
    }
}
