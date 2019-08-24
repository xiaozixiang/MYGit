namespace _44CodeFirstDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<dept> dept { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dept>()
                .Property(e => e.deptcode)
                .IsUnicode(false);

            modelBuilder.Entity<dept>()
                .Property(e => e.deptName)
                .IsUnicode(false);

            modelBuilder.Entity<dept>()
                .Property(e => e.parantCode)
                .IsUnicode(false);
        }
    }
}
