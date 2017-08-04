using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApp.Models
{
    public class State
    {
        public int Id { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }
}