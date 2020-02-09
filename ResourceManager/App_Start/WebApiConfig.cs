using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ResourceManager
{
    public static class WebApiConfig
    {
        public static IDriver Neo4jDriver { get; private set; }
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var url = ConfigurationManager.AppSettings["GraphDBUrl"];
            var username = ConfigurationManager.AppSettings["GraphDBUser"];
            var password = ConfigurationManager.AppSettings["GraphDBPassword"];
            var authToken = AuthTokens.None;

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(username))
                authToken = AuthTokens.Basic(username, password);


            Neo4jDriver = GraphDatabase.Driver(url, authToken);
        }
    }
}
