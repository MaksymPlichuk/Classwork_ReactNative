using Microsoft.AspNetCore.Identity;

namespace WebAPIDotNet.Data.Entities
{
    public class UserRoleEntity : IdentityUserRole<int>
    {
        public UserEntity User { get; set; } = null!;
        public RoleEntity Role { get; set; } = null!;
    }
}
