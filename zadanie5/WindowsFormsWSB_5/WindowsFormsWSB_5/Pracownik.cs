using System.Data.Linq.Mapping;

namespace WindowsFormsWSB_5
{
    [Table(Name = "Pracownicy")]
    public class Pracownik
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Imie;
        [Column(CanBeNull = false)] public string Nazwisko;
        [Column(CanBeNull = false)] public string Email;
        [Column(CanBeNull = false)] public string Telefon;
    }
}
