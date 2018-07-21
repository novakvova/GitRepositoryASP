namespace DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFContext : DbContext
    {
        public EFContext()
            : base("name=MSSQLConnection")
        {
        }
        public DbSet<Depatment> Depatments { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }

}