namespace KendoUIApp2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VisaDBContext : DbContext
    {
        public VisaDBContext()
            : base("name=VisaDBContext")
        {
        }

        public virtual DbSet<degree_types> degree_types { get; set; }
        public virtual DbSet<faculty> faculties { get; set; }
        public virtual DbSet<group> groups { get; set; }
        public virtual DbSet<nationality> nationalities { get; set; }
        public virtual DbSet<profession> professions { get; set; }
        public virtual DbSet<sitizenship_states> sitizenship_states { get; set; }
        public virtual DbSet<studyform> studyforms { get; set; }
        public virtual DbSet<uCity> uCities { get; set; }
        public virtual DbSet<uElineShakyrtu> uElineShakyrtus { get; set; }
        public virtual DbSet<uKetkender> uKetkenders { get; set; }
        public virtual DbSet<uOkuTuri> uOkuTuris { get; set; }
        public virtual DbSet<uOtbasyJagdai> uOtbasyJagdais { get; set; }
        public virtual DbSet<uPasport> uPasports { get; set; }
        public virtual DbSet<uRegistration> uRegistrations { get; set; }
        public virtual DbSet<uStudentTutor> uStudentTutors { get; set; }
        public virtual DbSet<uUser> uUsers { get; set; }
        public virtual DbSet<uVisa> uVisas { get; set; }
        public virtual DbSet<uVisaMatebe> uVisaMatebes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<uVisa>()
                .Property(e => e.VisaUzartuJyl)
                .IsFixedLength();
        }
    }
}
