using System.Data.Entity;
using SikhUnit.DataAccess.Context;

namespace SikhUnit.DataAccess.Migrations
{
    public class DatabaseInitialiser : MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>
    {
    }
}