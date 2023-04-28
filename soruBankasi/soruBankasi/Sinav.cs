using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class Sinav
    {
        private int id;
        private int ogretmenId;
        private string sinavAdi;
        private DateTime sinavTarihi;
        private List<Soru> sinavSorulari;

        public Sinav(int id, int ogretmenId, string sinavAdi, DateTime sinavTarihi)
        {
            this.id = id;
            this.ogretmenId = ogretmenId;
            this.sinavAdi = sinavAdi;
            this.sinavTarihi = sinavTarihi;
        }

        public Sinav(int ogretmenId, string sinavAdi, DateTime sinavTarihi)
        {
            this.ogretmenId = ogretmenId;
            this.sinavAdi = sinavAdi;
            this.sinavTarihi = sinavTarihi;
        }
        public int getId() { return id; }
        public int getOgretmenId() { return ogretmenId; }
        public string getSinavAdi() { return sinavAdi; }
        public DateTime getSinavTarihi() { return sinavTarihi; }
        public List<Soru> getSinavSorulari() { return sinavSorulari; }

        public void setId(int id) { this.id = id; }
        public void setOgretmenId(int ogretmenId) { this.ogretmenId = ogretmenId; }
        public void setSinavAdi(string sinavAdi) { this.sinavAdi = sinavAdi; }
        public void setSinavTarihi(DateTime sinavTariihi) { this.sinavTarihi = sinavTariihi; }
        public void setSinavSorulari(List<Soru> sorular) { this.sinavSorulari = sorular; }
    }
}
