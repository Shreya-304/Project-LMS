using NewLms.Models;
using Microsoft.EntityFrameworkCore;
using NewLms.ViewModels;

namespace NewLms.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet properties for your entities
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SkillAssessmentViewModel> SkillAssessments { get; set; }
    }
}
