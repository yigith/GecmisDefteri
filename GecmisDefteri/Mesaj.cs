using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GecmisDefteri
{
    public class Mesaj : IComparable
    {
        public Mesaj()
        {

        }

        public Mesaj(string icerik)
        {
            Icerik = icerik;
        }

        public DateTime Zaman { get; set; } = DateTime.Now;
        public string Icerik { get; set; }
        public bool YildizliMi { get; set; }

        public int CompareTo(object diger)
        {
            Mesaj digerMesaj = (Mesaj)diger;
            return -Zaman.CompareTo(digerMesaj.Zaman);
        }

        public override string ToString()
        {
            string yildiz = YildizliMi ? "★" : "☆";

            string tarih = Zaman.Date == DateTime.Now.Date
                ? Zaman.ToString("HH:mm")
                : Zaman.ToString("dd.MM.yyyy HH:mm");

            return $"{yildiz} [{tarih}] {Icerik}";
        }
    }
}
