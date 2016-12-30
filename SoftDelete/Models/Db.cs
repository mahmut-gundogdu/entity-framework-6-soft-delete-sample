using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SoftDelete.Models
{
    public class Db : DbContext
    {
        public Db() : base("Db")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyContext>(modelBuilder);
            //Database.SetInitializer(sqliteConnectionInitializer);
            modelBuilder.Conventions
                        .Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<Kisi>()
                            .Map(m => m.Requires("SilindiMi").HasValue(false))
                            .Ignore(m => m.SilindiMi);

        }


        public DbSet<Kisi> Kisiler { get; set; }
    }
}