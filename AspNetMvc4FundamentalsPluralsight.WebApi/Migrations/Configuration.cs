namespace AspNetMvc4FundamentalsPluralsight.WebApi.Migrations
{
    using AspNetMvc4FundamentalsPluralsight.WebApi.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvc4FundamentalsPluralsight.WebApi.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AspNetMvc4FundamentalsPluralsight.WebApi.Models.VideoDb context)
        {
            context.Videos.AddOrUpdate(x => x.Title,
                new Video { Title = "MVC4", Length = 120 },
                new Video { Title = "LINQ", Length = 150 });

            context.SaveChanges();
        }
    }
}
