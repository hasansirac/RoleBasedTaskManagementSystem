using System;
using System.Collections.Generic;
using RoleBasedTaskManagementSystem.Domain.Common;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public List<ProjectMember> ProjectMembers { get; set; }

        public List<TaskItem> AssignedTasks { get; set; }
        
        public List<ActivityLog> ActivityLogs { get; set; }
    }
}