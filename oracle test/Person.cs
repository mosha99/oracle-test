using System.ComponentModel.DataAnnotations.Schema;

namespace oracle_test;

[Table("PEPOLE",Schema = "SWIFTMX")]
public class Person
{
    [Column("ID")]
    public int Id { set; get; }
    [Column("NAME")]
    public string Name { set; get; }
}