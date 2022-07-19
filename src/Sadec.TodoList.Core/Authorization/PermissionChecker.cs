using Abp.Authorization;
using Sadec.TodoList.Authorization.Roles;
using Sadec.TodoList.Authorization.Users;

namespace Sadec.TodoList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
