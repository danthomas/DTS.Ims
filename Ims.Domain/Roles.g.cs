using System;

namespace Ims.Domain
{
    public class Roles
    {
        public Roles(short roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
    
        public short RoleId { get; set; }
        public string RoleName { get; set; }
    }
}