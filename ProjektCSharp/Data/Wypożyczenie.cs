using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjektCSharp.Data
{
    internal class Wypożyczenie
    {
        [Key]
        public int Id_klient { get; set; }
        public int Id_film { get; set; }
        public DateTime Data_wypożyczenia { get { return DateTime.Now; } }

    }
}