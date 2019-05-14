using Abp.Authorization;
using Psy.Authorization.Roles;
using Psy.Authorization.Users;

namespace Psy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
