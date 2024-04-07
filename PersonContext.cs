using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqlite
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Table_One> Table_One { get; set; }
        public DbSet<Table_Two> Table_Two { get; set; }
        public DbSet<Table_Three> Table_Three { get; set; }
        public DbSet<FluentApiTable> FluentApiTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=TestDatabaseEnglish.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FluentApiTable>().HasKey(a => a.Indetifier);
            modelBuilder.Entity<FluentApiTable>().Property(a => a.Value).IsRequired().HasColumnName("Thats the column name");
        }
    }

    public class FluentApiTable
    {
        public int Indetifier { get; set; }
        public string Value { get; set; }
    }

    public class Table_One
    {
        public int Id { get; set; }
    }
    public class Table_Two
    {
        public int Table_TwoId { get; set; }
    }
    public class Table_Three
    {
        [Key]
        public int Identifier { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

/* Package Manager Console:
 * Add-Migration InitialCreate
 * Update-Database
 * 
 * Package Manager Console: To Add Changes (Table-One to Three)
 * Add-Migration DataAnnotations_1
 * Update-Database
 */