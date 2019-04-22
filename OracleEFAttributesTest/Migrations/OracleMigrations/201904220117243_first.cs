namespace OracleEFAttributesTest.Migrations.OracleMigrations
{
    using System.Data.Entity.Migrations;

    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "TEST.SomeModels",
                c => new
                    {
                        SomeKey = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                    })
                .PrimaryKey(t => t.SomeKey);
            
        }
        
        public override void Down()
        {
            DropTable("TEST.SomeModels");
        }
    }
}
