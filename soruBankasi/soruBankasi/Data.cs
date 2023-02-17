using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class Data
    {
        public static List<Ogretmen> ogretmenler = new List<Ogretmen>();
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static List<SinavK> sinavlar = new List<SinavK>();
        public static List<List<Soru>> arsiv = new List<List<Soru>>();
        public static Ogrenci DOgrenci;
        public static Ogretmen DOgretmen;
    }
}
