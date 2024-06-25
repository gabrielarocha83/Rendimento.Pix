using Rendimento.Pix.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rendimento.Pix.Services.Services
{
    public class RequisicaoAcessoServices : IRequisicaoAcessoServices
    {
        private readonly HttpClient _httpClient;
        public RequisicaoAcessoServices()
        {
            _httpClient = new HttpClient();
        }

        private void AddHeaders(HttpContent request, Domain.Request.AcessToken credencial)
        {
            request.Headers.Add("Authorization", credencial.Authorization);
            request.Headers.Add("client_id", credencial.client_id);
            request.Headers.Add("client_secret", credencial.client_secret);
            request.Headers.Add("acess_token", credencial.acess_token);
            request.Headers.Add("grand_type", "client_credencials");

        }
        public async Task<Domain.Response.AcessToken> Autenticacao(Domain.Request.AcessToken credencial)
        {

               var request = new HttpRequestMessage(HttpMethod.Post, credencial.url);



            
            
            request.Headers.Add("Authorization", credencial.Authorization);
            request.Headers.Add("client_id", credencial.client_id);
            request.Headers.Add("client_secret", credencial.client_secret);
            request.Headers.Add("access_token", credencial.acess_token);

            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("grant_type", "client_credentials"));

            var content = new FormUrlEncodedContent(collection);
            request.Content = content;

            string responseBody = "";

              //  AddHeaders(request, credencial);
                HttpResponseMessage response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                responseBody =  await response.Content.ReadAsStringAsync();
              
                Domain.Response.AcessToken resultado = new Domain.Response.AcessToken();
                resultado = JsonSerializer.Deserialize<Domain.Response.AcessToken>(responseBody);
                return resultado;

            

           
        }

        
    }
}
