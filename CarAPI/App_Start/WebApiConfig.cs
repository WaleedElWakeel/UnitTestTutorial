using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using CarAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace CarAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<ICarRepository, CarsRepository>();
            container.RegisterType<IOwnerRepository, OwnerRepository>();
            container.RegisterType<InMemoryContext>();
            container.RegisterType<ICarService, CarService>();
            container.RegisterType<IOwnerService, OwnerService>();
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
