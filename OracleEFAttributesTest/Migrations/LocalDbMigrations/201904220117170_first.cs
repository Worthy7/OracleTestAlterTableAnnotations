namespace OracleEFAttributesTest.Migrations.LocalDbMigrations
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
                        SomeKey = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SomeKey);
            
        }
        
        public override void Down()
        {
            DropTable("TEST.SomeModels");
        }
    }
}
