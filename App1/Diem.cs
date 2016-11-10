using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Diem
    {
        public string MaSv, MaMon, LanThi, NgayThi;
        public int DiemThi;

        public Diem(string pMaSv,string pMaMon,string pLanThi,string pNgayThi,int pDiem)
        {
            this.MaSv = pMaSv;
            this.MaMon = pMaMon;
            this.LanThi = pLanThi;
            this.NgayThi = pNgayThi;
            this.DiemThi = pDiem;
        }
    }
}
