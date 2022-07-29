using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Folder
{
    [DebuggerDisplay("{adr_Id} {adr_Nazwa}")]
    public class AdrEwid
    {
        public AdrEwid()
        {
            AdrEmails = new List<AdrEmail>();
        }

        [Key]
        public int adr_Id { get; set; }
        public int adr_IdObiektu { get; set; }
        public int adr_TypAdresu { get; set; }
        public string adr_Nazwa { get; set; }
        public string adr_NazwaPelna { get; set; }
        public string adr_Telefon { get; set; }
        public string adr_Faks { get; set; }
        public string adr_Ulica { get; set; }
        public string adr_NrDomu { get; set; }
        public string adr_NrLokalu { get; set; }
        public string adr_Adres { get; set; }
        public string adr_Kod { get; set; }
        public string adr_Miejscowosc { get; set; }
        public int? adr_IdWojewodztwo { get; set; }
        public int? adr_IdPanstwo { get; set; }
        public string adr_NIP { get; set; }
        public string adr_Poczta { get; set; }
        public string adr_Gmina { get; set; }
        public string adr_Powiat { get; set; }
        public string adr_Skrytka { get; set; }
        public string adr_Symbol { get; set; }
        public int? adr_IdGminy { get; set; }
        public int? adr_IdWersja { get; set; }
        public int? adr_IdZmienil { get; set; }
        public DateTime? adr_DataZmiany { get; set; }
        public string adr_NrUrzeduSkarbowego { get; set; }
        public string adr_NrEORI { get; set; }

        public List<AdrEmail> AdrEmails { get; set; }
    }
}
