using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoleBasedTaskManagementSystem.Domain.Entities;

namespace RoleBasedTaskManagementSystem.Persistence.Configurations
{
    public class ActivityLogConfiguration : IEntityTypeConfiguration<ActivityLog>
    {
        public void Configure(EntityTypeBuilder<ActivityLog> builder)
        {
            builder.ToTable("ActivityLogs");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Action)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(x => x.User)
                .WithMany(x => x.ActivityLogs)
                .HasForeignKey(x => x.UserId);
        }
    }
}
