using RoleBasedTaskManagementSystem.Domain.Common;

namespace RoleBasedTaskManagementSystem.Domain.Entities
{
    public class ActivityLog : BaseEntity
    {
        public string Action { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
