using System.ComponentModel.DataAnnotations;

namespace OracleEFAttributesTest
{
    public class SomeModel
    {
        [Key]
        public int SomeKey { get; set; }
    }
}
