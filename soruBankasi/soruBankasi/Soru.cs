using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class Soru
    {
        private int id;
        private int sinavId;
        private string metin;
        private string a;
        private string b;
        private string c;
        private string d;
        private string e;
        private string cevap;

        public Soru() { }
        public Soru(int sinavId) { this.sinavId = sinavId; }

        public Soru(int id, int sinavId, string metin, string a, string b, string c, string d, string e, string cevap)
        {
            this.id = id;
            this.sinavId = sinavId;
            this.metin = metin;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.cevap = cevap;
        }
        public Soru(int sinavId, string metin, string a, string b, string c, string d, string e, string cevap)
        {
            this.sinavId = sinavId;
            this.metin = metin;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.cevap = cevap;
        }

        public int getId() { return id; }
        public int getSinavId() { return sinavId; }
        public string getMetin() { return metin; }
        public string getA() { return this.a; }
        public string getB() { return this.b; }
        public string getC() { return this.c; }
        public string getD() { return this.d; }
        public string getE() { return this.e; }
        public string getCevap() { return this.cevap; }

        public void setMetin(string metin) { this.metin = metin; }
        public void setA(string a) { this.a = a; }
        public void setB(string b) { this.b = b; }
        public void setC(string c) { this.c = c; }
        public void setD(string d) { this.d = d; }
        public void setE(string e) { this.e = e; }
        public void setCevap(string cevap) { this.cevap = cevap; }


    }
}
