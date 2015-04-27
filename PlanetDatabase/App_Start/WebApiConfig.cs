using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PlanetDatabase
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Enable CORS
            config.EnableCors(new EnableCorsAttribute("*", "*", "*")); 

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Ensure JSON is default Web Api Format
            var jsonFormatter = config.Formatters.JsonFormatter;
            
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            
            jsonFormatter.SerializerSettings = jsonSerializerSettings;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            

        }
    }
}
