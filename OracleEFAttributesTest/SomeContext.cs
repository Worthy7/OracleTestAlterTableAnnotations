using System.Data.Entity;

namespace OracleEFAttributesTest
{
    public class SomeContext : DbContext
    {
        public SomeContext(string contextString) : base(contextString)
        {

        }
        public virtual DbSet<SomeModel> SomeModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("TEST");
            modelBuilder.Types().Configure(p => p.HasTableAnnotation("SomeAnnotationName", "SomeAnnotationValue"));
        }
    }
}
