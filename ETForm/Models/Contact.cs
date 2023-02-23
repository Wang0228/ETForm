using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace ETForm.Models
{
    public partial class Contact : DbContext
    {
        public Contact()
            : base("name=Contact")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",Directory.GetCurrentDirectory());
        }

        public virtual DbSet<Table> Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
