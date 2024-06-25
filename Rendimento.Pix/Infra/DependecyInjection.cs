
using Rendimento.Pix.Services.Services;

namespace Rendimento.Pix.Infra
{
    public static class DependecyInjection
    {

        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<Services.Interface.IRequisicaoAcessoServices, Services.Services.RequisicaoAcessoServices>();
        }
    }
}
