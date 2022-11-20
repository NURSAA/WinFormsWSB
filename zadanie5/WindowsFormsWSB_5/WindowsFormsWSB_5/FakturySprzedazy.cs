using System;
using System.Data.Linq.Mapping;

namespace WindowsFormsWSB_5
{
    [Table(Name = "FakturySprzedazy")]
    public class FakturySprzedazy
    {
        [Column(Name = "Id", IsPrimaryKey = true, CanBeNull = false)] public int Id;
        [Column(CanBeNull = false)] public string Numer;
        [Column(CanBeNull = false)] public double Netto;
        [Column(CanBeNull = true)] public double? Vat;
        [Column(Name = "Zapłacono", CanBeNull = true)] public double? Zaplacono;
        [Column(CanBeNull = false)] public DateTime Data;
        [Column(CanBeNull = false)] public int KontrahentId;
        [Column(CanBeNull = false)] public int PracownikId;
    }
}
