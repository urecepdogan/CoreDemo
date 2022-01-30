using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class FiyatTeklif
    {
        [Key]
        public int TeklifID { get; set; }
        public int KursFiyat { get; set; }
        public string KayıtAyi { get; set; }
        public int ErkenKayitIndirimMiktari { get; set; }
        public DateTime GorusmeTarih { get; set; }
        public int Okulu { get; set; }
        public int BurslulukSinavDerecesi { get; set; }
        public int SinavOkulIndirimMiktari { get; set; }
        public string DigerIndirim { get; set; }
        public int DigerIndirimMiktari { get; set; }
        public string EkstraIndirimNedeni { get; set; }
        public int EkstraIndirimMiktari { get; set; }
        public int ToplamIndirimMiktari { get; set; }
        public int IndirimliKayitUcreti { get; set; }
        public int OgrenciID { get; set; }
        public OgrenciBilgi Ogrenci { get; set; }

    }
}
