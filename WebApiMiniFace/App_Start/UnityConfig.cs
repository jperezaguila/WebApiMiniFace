using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using WebApiMiniFace.Models;
using WebApiMiniFace.Repositorios;

namespace WebApiMiniFace
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            //Siempre en este orden:
            container.RegisterType<DbContext, MiniFaceDBEntities>();
            container.RegisterType<UsuarioRepositorio>();
            //26-01
            container.RegisterType<MensajeRepositorio>();
            container.RegisterType<ContactoRespositorio>();
            //--
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}