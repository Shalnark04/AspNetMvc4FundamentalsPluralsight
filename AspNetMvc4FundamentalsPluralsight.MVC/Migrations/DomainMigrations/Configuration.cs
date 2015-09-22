namespace AspNetMvc4FundamentalsPluralsight.MVC.Migrations.DomainMigrations
{
    using AspNetMvc4FundamentalsPluralsight.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure.CompanyDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\DomainMigrations";
        }

        protected override void Seed(AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure.CompanyDb context)
        {
            context.Departments.AddOrUpdate(x => x.Name,
                new Department { Name = "Engineering" },
                new Department { Name = "Production" });
        }
    }
}
