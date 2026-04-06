using RoleBasedTaskManagementSystem.Domain.Common;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class ProjectMember : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}