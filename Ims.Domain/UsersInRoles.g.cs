using System;

namespace Ims.Domain
{
    public class UsersInRoles
    {
        public UsersInRoles(int userId, short roleId)
        {
            UserId = userId;
            RoleId = roleId;
        }
    
        public int UserId { get; set; }
        public short RoleId { get; set; }
    }
}