using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruBankasi
{
    internal class Ogrenci
    {
        private int id;
        private string name;
        private string no;
        private string sinif;
        private string sube;

        public Ogrenci(string name, string no, string sinif, string sube)
        {
            this.name = name;
            this.no = no;
            this.sinif = sinif;
            this.sube = sube;
        }

        public Ogrenci(int id ,string name, string no, string sinif, string sube)
        {
            this.id = id;
            this.name = name;
            this.no = no;
            this.sinif = sinif;
            this.sube = sube;
        }

        public string getName()
        {
            return this.name;
        }
        public string getNo()
        {
            return this.no;
        }

        public string getSinif()
        {
            return this.sinif;
        }

        public string getSube()
        {
            return this.sube;
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

        public void setSinif(string sinif)
        {
            this.sinif = sinif;
        }

        public void setSube(string sube)
        {
            this.sube = sube;
        }
    }
}
