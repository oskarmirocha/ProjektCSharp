using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektCSharp.Data
{
    internal class Wypożyczenie
    {
        public int Id_klient { get; set; }
        public int Id_film { get; set; }
        public DateTime Data_wypożyczenia { get { return DateTime.Now; } }

    }
}