using System;

namespace Repository
{
    public class Person
    {
        public int Kontakt_Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Firma { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public bool? Kunde { get; set; }
        public DateTime? Anruf { get; set; }
    }
}
