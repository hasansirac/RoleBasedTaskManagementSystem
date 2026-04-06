using System.Collections.Generic;
using RoleBasedTaskManagementSystem.Domain.Common;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}