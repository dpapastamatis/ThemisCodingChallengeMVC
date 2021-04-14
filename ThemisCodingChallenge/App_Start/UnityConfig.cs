using System.Web.Http;
using System.Web.Mvc;
using ThemisCodingChallenge.Controllers;
using ThemisCodingChallenge.Controllers.Api;
using ThemisCodingChallenge.Implementations;
using ThemisCodingChallenge.Interfaces;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;

namespace ThemisCodingChallenge
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			
            var container = new UnityContainer();
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            container.RegisterType<IEmployeesWebServices, EmployeesWebServicesFromDB>(new HierarchicalLifetimeManager());

            container.RegisterType<AccountController>(new InjectionConstructor());
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}