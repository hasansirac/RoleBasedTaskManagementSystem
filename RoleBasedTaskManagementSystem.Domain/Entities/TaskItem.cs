using RoleBasedTaskManagementSystem.Domain.Common;
using RoleBasedTaskManagementSystem.Domain.Enums;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public Enums.TaskStatus Status { get; set; }

        public TaskPriority Priority { get; set; }

        public DateTime? Deadline { get; set; }
    }
}