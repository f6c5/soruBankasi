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
        private char dogruCevap;

        public Soru(int id, string metin, string a, string b, string c, string d, string e, char dogruCevap)
        {
            this.id = id;
            this.metin = metin;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.dogruCevap = dogruCevap;
        }

        public int getId() { return id; }

        public Soru getSoru()
        {
            return this;
        }

        public char getDogruCevap()
        {
            return dogruCevap;
        }
    }
}
