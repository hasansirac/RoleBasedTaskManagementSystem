using RoleBasedTaskManagementSystem.Domain.Common;

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
    }
}