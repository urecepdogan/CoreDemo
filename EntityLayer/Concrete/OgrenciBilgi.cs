using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class OgrenciBilgi
    {
        [Key]
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public string Okulu { get; set; }
        public string Bolumu { get; set; }
        public string AnneAdiSoyadi { get; set; }
        public string AnneMeslegi { get; set; }
        public string AnneTelefonu { get; set; }
        public string BabaAdiSoyadi { get; set; }
        public string BabaMeslegi { get; set; }
        public string BabaTelefonu { get; set; }
        public string SmsKime { get; set; }
        public string KayitAlanGorevli { get; set; }
        public string Notlar { get; set; }
        public List<FiyatTeklif> FiyatTeklifs { get; set; }
    }
}
