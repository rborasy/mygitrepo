using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApp.Models
{
    public class UserProfile
    { 
        public int Id {get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public virtual ApplicationUser User { get; set; }
    }

}