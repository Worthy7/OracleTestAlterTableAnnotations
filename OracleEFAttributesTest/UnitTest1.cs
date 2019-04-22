using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Linq;

namespace OracleEFAttributesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLocalDbSqlGeneration()
        {
            TestSqlGeneration(new OracleEFAttributesTest.Migrations.LocalDbMigrations.Configuration());
        }

        [TestMethod]
        public void TestOracleSqlGeneration()
        {
            TestSqlGeneration(new OracleEFAttributesTest.Migrations.OracleMigrations.Configuration());
        }

        private void TestSqlGeneration<T>(DbMigrationsConfiguration<T> configuration) where T:DbContext
        {            
            var migrator = new DbMigrator(configuration);
            var scriptingMigrator = new MigratorScriptingDecorator(migrator);

            var migrations = migrator.GetLocalMigrations().OrderBy(c => c).ToList();
            // NOTE: go from first to annotateTable
            var str = scriptingMigrator.ScriptUpdate(migrations.First(c=>c.Contains("first")), migrations.First(c=>c.Contains("annotate")));
            
        }
    }
}
