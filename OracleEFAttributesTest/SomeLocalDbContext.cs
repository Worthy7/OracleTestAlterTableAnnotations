namespace OracleEFAttributesTest
{
    public class SomeLocalDbContext : SomeContext
    {
        public SomeLocalDbContext() : base("SqlLocalContext")
        {
        }
    }
}
