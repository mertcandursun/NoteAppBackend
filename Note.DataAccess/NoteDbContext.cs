using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Note.DataAccess
{
    public class NoteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-BELVBNK\\SQLEXPRESS; DataBase=NoteAppDB; Trusted_Connection=True;");
        }

        public DbSet<Entities.Note> Notes { get; set; }
    }
}
