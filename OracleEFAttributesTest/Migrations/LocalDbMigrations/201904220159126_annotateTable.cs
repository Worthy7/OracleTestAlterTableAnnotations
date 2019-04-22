namespace OracleEFAttributesTest.Migrations.LocalDbMigrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;

    public partial class annotateTable : DbMigration
    {
        public override void Up()
        {
            AlterTableAnnotations(
                "TEST.SomeModels",
                c => new
                    {
                        SomeKey = c.Int(nullable: false, identity: true),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "SomeAnnotationName",
                        new AnnotationValues(oldValue: null, newValue: "SomeAnnotationValue")
                    },
                });
            
        }
        
        public override void Down()
        {
            AlterTableAnnotations(
                "TEST.SomeModels",
                c => new
                    {
                        SomeKey = c.Int(nullable: false, identity: true),
                    },
                annotations: new Dictionary<string, AnnotationValues>
                {
                    { 
                        "SomeAnnotationName",
                        new AnnotationValues(oldValue: "SomeAnnotationValue", newValue: null)
                    },
                });
            
        }
    }
}
