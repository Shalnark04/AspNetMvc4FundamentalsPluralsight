namespace AspNetMvc4FundamentalsPluralsight.MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure.CompanyDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure.CompanyDb context)
        {
            
        }
    }
}
