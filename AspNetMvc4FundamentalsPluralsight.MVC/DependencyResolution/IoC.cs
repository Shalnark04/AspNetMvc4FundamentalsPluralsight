using AspNetMvc4FundamentalsPluralsight.DAL;
using AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure;
using StructureMap;
namespace AspNetMvc4FundamentalsPluralsight.MVC {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<ICompanyDataSource>().HttpContextScoped().Use<CompanyRepository>();
                        });
            return ObjectFactory.Container;
        }
    }
}