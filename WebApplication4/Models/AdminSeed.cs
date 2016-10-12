//using System.Linq;
//using IdentitySample.Models;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;

//namespace IdentitySample.Models
//{
//    int AdminSeed; 
//    public void AdminSeed(ApplicationDbContext context)
//    {
//        if (!context.Roles.Any(r => r.Name == "AppAdmin"))
//        {
//            var store = new RoleStore<IdentityRole>(context);
//            var manager = new RoleManager<IdentityRole>(store);
//            var role = new IdentityRole { Name = "AppAdmin" };

//            manager.Create(role);
//        }

//        if (!context.Users.Any(u => u.UserName == "founder"))
//        {
//            var store = new UserStore<ApplicationUser>(context);
//            var manager = new UserManager<ApplicationUser>(store);
//            var user = new ApplicationUser { UserName = "founder" };

//            manager.Create(user, "ChangeItAsap!");
//            manager.AddToRole(user.Id, "AppAdmin");
//        }
//    }
//}