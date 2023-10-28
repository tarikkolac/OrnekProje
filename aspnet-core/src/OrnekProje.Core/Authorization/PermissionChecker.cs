using Abp.Authorization;
using OrnekProje.Authorization.Roles;
using OrnekProje.Authorization.Users;

namespace OrnekProje.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
