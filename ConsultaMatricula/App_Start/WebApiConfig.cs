using System.Web.Http;
using System.Web.Http.Cors;

namespace ConsultaMatricula
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuração do CORS
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);

            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
