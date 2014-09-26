using System.Configuration;
using System.Data.Entity;
using SikhUnit.Domain.Entity;

namespace SikhUnit.DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString)
        { 
        }

        public IDbSet<Album> Albums { get; set; }
        public IDbSet<Literature> Literatures { get; set; }
        public IDbSet<Song> Songs { get; set; }
    }
}