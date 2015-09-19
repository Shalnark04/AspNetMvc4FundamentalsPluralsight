using System.Web.Mvc;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(AspNetMvc4FundamentalsPluralsight.MVC.App_Start.StructuremapMvc), "Start")]

namespace AspNetMvc4FundamentalsPluralsight.MVC.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}