using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
     class Sinhvien
    {
        public string Ma;
        private string _Ten;

        public string Ten
        {
            get { return _Ten.ToUpper(); }
            set { _Ten = value; }
        }
        public Sinhvien(string pMa, string pTen){
            this.Ma = pMa;
            this.Ten = pTen;
        }
        public virtual void say()
        {
            Console.WriteLine("Hello");
        }

    }

    class SinhvienGioi : Sinhvien
    {
        public string loaiSv;
        public SinhvienGioi(string pMa, string pTen,string ploaiSv):base(pMa, pTen)
        {
            this.loaiSv = ploaiSv;
        }
        public override void say()
        {
            Console.WriteLine("SV Gioi Says hello");
        }
    }
}
