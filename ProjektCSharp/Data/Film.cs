using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektCSharp.Data
{
    public class Film
    {
        [Key]
        public int Id_film { get; set; }
        public string Tytuł { get; set; }
        public string Gatunek { get; set; }
        public string Reżyser { get; set; }
    }
}
