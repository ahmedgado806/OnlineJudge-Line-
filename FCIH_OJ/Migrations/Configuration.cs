namespace FCIH_OJ.Migrations
{
    using FCIH_OJ.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FCIH_OJ.Models.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FCIH_OJ.Models.UsersContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            context.Users.AddOrUpdate(
                p => p.Username,
                new User { 
                    Username = "root" ,
                    Email = "root@root.com"
                }
            );
        }
    }
}
