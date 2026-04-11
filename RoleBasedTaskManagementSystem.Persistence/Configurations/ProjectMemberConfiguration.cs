using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoleBasedTaskManagementSystem.Domain.Entities;

namespace RoleBasedTaskManagementSystem.Persistence.Configurations
{
    public class ProjectMemberConfiguration : IEntityTypeConfiguration<ProjectMember>
    {
        public void Configure(EntityTypeBuilder<ProjectMember> builder)
        {
            builder.ToTable("ProjectMembers");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.ProjectMembers)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Project)
                .WithMany(x => x.ProjectMembers)
                .HasForeignKey(x => x.ProjectId);
        }
    }
}