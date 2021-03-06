﻿using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json.Serialization;

namespace WebAPIWithAngular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("http://localhost:4200/sugarlevel-list", "*", "*");
            config.EnableCors(cors);

            // Web API configuration and services

            // Web API routes

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


           var jsonFormatter = config.Formatters.JsonFormatter;
           jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
           config.Formatters.Remove(config.Formatters.XmlFormatter);
           jsonFormatter.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
        }
    }
}
