using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TesePortal.Models
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationContext() : base("IdentityDb") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}