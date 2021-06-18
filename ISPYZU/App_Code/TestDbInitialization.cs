using ISPYZU.Models; // TestDbContext
using System;
using System.Collections.Generic;
using System.Data.Entity; // DropCreateDatabaseAlways<DbContext>
using System.Linq;
using System.Web;


namespace ISPYZU.App_Code
{
  //ALT+Enter for twice! using two namespaces!
  public class TestDbInitialization : DropCreateDatabaseAlways<TestDbContext>
  {
    //set the seed, which is used for add data to the tables in the database!
    //  after creating the database
    protected override void Seed(TestDbContext context)
    {

            
            var roles = new List<Role>
      {
        new Role { RoleName = "Teacher", Description = "Managing_department" },
        new Role { RoleName = "Admin", Description = "Directing_department"},
        new Role { RoleName = "Student", Description = "Learning_department"}
      };
            roles.ForEach(r => context.Roles.Add(r));
            context.SaveChanges();

            var users = new List<User>
      {
        new User {UserName="Noman",  Password="123456", RoleId=2},
        new User {UserName="Shorif",  Password="123456", RoleId=2},
        new User {UserName="Siam",  Password="123456", RoleId=2},
        new User {UserName="Admin",  Password="123456", RoleId=2},
       
      };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            base.Seed(context);
    }
  }
}