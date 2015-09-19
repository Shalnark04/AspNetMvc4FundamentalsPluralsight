namespace AspNetMvc4FundamentalsPluralsight.MVC.Migrations
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
        }

        //every time the schema will change/database will be recreated, make sure the database will be populated with departments listed below
        protected override void Seed(AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure.CompanyDb context)
        {
            context.Departments.AddOrUpdate(x => x.Name,
                new Department() { Name = "Engineering" },
                new Department { Name = "IT" },
                new Department { Name = "Human Resources" },
                new Department {Name="Sales"}
                );
        }
    }
}
