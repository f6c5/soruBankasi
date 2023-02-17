using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class Ogretmen
    {
        private int id;
        private string name;
        private string no;
        private string sifre;

        public Ogretmen()
        {

        }

        public Ogretmen(int id,string name, string no, string sifre)
        {
            this.id = id;
            this.name = name;
            this.no = no;
            this.sifre = sifre;
        }

        public string getName()
        {
            return this.name;
        }

        public string getNo()
        {
            return this.no;
        }
        public string getSifre()
        {
            return this.sifre;
        }

        public int getId()
        {
            return this.id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setNo(string no)
        {
            this.no = no;
        }

        public void setSifre(string sifre)
        {
            this.sifre = sifre;
        }
    }
}
