using System.Collections.Generic;
using RoleBasedTaskManagementSystem.Domain.Common;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<ProjectMember> ProjectMembers { get; set; }

        public List<TaskItem> Tasks { get; set; }
    }
}
