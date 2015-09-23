namespace AspNetMvc4FundamentalsPluralsight.MVC.Migrations.UserManagementMigrations
{
    using AspNetMvc4FundamentalsPluralsight.MVC.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetMvc4FundamentalsPluralsight.MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\UserManagementMigrations";
            ContextKey = "AspNetMvc4FundamentalsPluralsight.MVC.Models.ApplicationDbContext";
        }

        protected override void Seed(AspNetMvc4FundamentalsPluralsight.MVC.Models.ApplicationDbContext context)
        {
            if(!context.Users.Any(x=>x.UserName=="lbebenek@khprint.com"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var user = new ApplicationUser { UserName = "lbebenek@khprint.com" };

                userManager.Create(user, "password");
                roleManager.Create(new IdentityRole { Name = "Admin" });
                userManager.AddToRole(user.Id, "admin");
            }
        }
    }
}
