using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektCSharp.Data
{
    internal class Klient
    {
        [Key]
        public int Id_klient { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Numer_telefonu { get; set; }


    }
}
