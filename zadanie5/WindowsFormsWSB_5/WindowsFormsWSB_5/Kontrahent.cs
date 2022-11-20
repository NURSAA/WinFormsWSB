using System.Data.Linq.Mapping;

namespace WindowsFormsWSB_5
{
    [Table(Name = "Kontrahenci")]
    public class Kontrahent
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Nazwa;
        [Column(CanBeNull = true)] public string Nip;
        [Column(CanBeNull = false)] public string Ulica;
        [Column(CanBeNull = false)] public string Miasto;
    }
}
