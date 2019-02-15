using HelpDesk.BussinessLogic.Interface;
using HelpDesk.BussinessLogic.Interface.Master;
using HelpDesk.Common.Interface;
using HelpDesk.Common.Interface.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace HelpDesk.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //this is service area
            container.RegisterType<IProvinceService, ProvinceService>();

            //this is repository area
            container.RegisterType<IProvinceRepository, ProvinceRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}