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
        private string branch;
       
       

        public Ogretmen( string name, string no, string sifre, string branch )
        {
            this.name = name;
            this.no = no;
            this.sifre = sifre;
            this.branch = branch;
        }

        public Ogretmen(int id,string name, string no, string sifre, string branch)
        {
            this.id = id;
            this.name = name;
            this.no = no;
            this.sifre = sifre;
            this.branch = branch;
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
        public string getBranch()
        {
            return this.branch;
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
