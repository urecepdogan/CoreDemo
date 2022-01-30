using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Taksit
    {
        [Key]
        public int TaksitID { get; set; }
        public int TaksitSayisi { get; set; }
        public DateTime TaksitTarihi { get; set; }
        public int TaksitMiktari { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public int OdemeMiktari { get; set; }
        public int ToplamOdenen { get; set; }

    }
}
