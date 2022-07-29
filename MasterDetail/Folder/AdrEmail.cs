using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail.Folder
{
    [DebuggerDisplay("{am_Id} {am_IdAdres}")]
    public class AdrEmail
    {
        public AdrEmail() { }

        [Key]
        public int am_Id { get; set; }
        public int am_IdAdres { get; set; }
        public string am_Email { get; set; }
        public int am_Rodzaj { get; set; }
        public bool am_Podstawowy { get; set; }

        public int FK_adr_Email_adr__Ewid { get; set; }
        public AdrEwid AdrEwid { get; set; }
    }
}
