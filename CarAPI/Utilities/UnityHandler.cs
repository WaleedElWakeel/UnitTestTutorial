using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace CarAPI.Utilities
{
    public static  class UnityHandler
    {
        public static UnityContainer Container { get; set; }
        static UnityHandler()
        {
            Container = new UnityContainer();
            Register();
        }

        private static void Register()
        {
            Container.RegisterType<ICarRepository, CarsRepository>();
            Container.RegisterType<InMemoryContext>();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}