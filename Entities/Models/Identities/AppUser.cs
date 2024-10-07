
using Microsoft.AspNetCore.Identity;

namespace Entities.Models.Identities
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public long NationalyId { get; set; }
    }
}