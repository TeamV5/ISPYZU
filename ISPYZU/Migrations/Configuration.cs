namespace ISPYZU.Migrations
{
    using ISPYZU.App_Code;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ISPYZU.Models.TestDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ISPYZU.Models.TestDbContext context)
        {
           
            //  This method will be called after migrating to the latest version.
         
             TestDbInitialization init = new TestDbInitialization();
           init.InitializeDatabase(context);  
            
            
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
