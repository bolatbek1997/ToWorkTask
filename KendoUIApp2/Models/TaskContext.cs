using System.Data.Entity;

namespace KendoUIApp2.Models
{
    public partial class TaskContext : DbContext
    {
        public TaskContext()
            : base("name=Task")
        {
        }
        public virtual DbSet<Tasks> Tasks { get; set; }
    }
}