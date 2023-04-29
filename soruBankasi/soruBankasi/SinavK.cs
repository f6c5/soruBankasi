using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class SinavK
    {
        private int id;
        private List<Soru> sorular;
        private int ogrenciId;
        private float soruPuan;
        private float ogrenciPuan = 0;
        private List<string> cevaplar;

        public SinavK(int id, List<Soru> sorular)
        {
            this.id = id;
            this.sorular = sorular;
            this.soruPuan = 100 / sorular.Count;
        }

        public int getId() { return id; }

        public float getOgrenciPuan()
        {

            for (int i = 0; i < sorular.Count; i++)
            {
                if (cevaplar[i] == sorular[i].getCevap())
                {
                    this.ogrenciPuan += this.soruPuan;
                }
            }

            return this.ogrenciPuan;
        }

        public int getOgrenciId()
        {
            return this.ogrenciId;
        }

        public List<Soru> getSorular()
        {
            return this.sorular;
        }

        public void setOgrenciId(int id)
        {
            this.ogrenciId = id;
        }

        public void setCevap(int soruNumara, string cevap)
        {
            this.cevaplar[soruNumara] = cevap;
        }
        public void setSinavSorulari(List<Soru> sorular) { this.sorular = sorular; }
    }
}
