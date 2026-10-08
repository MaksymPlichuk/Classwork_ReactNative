using Microsoft.AspNetCore.Identity;

namespace WebAPIDotNet.Data.Entities
{
    public class RoleEntity : IdentityRole<int>
    {
        public ICollection<UserRoleEntity>? UserRoles { get; set; }
    }
}
