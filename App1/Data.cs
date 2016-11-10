using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace App1
{
    class Data
    {
        public static ArrayList SinhVienList= new ArrayList();
        public static Hashtable MonHocList = new Hashtable();
        public static void Khoitao()
        {
            SinhVienList.Add(new Sinhvien("1", "Nguyen Thi Minh"));
            SinhVienList.Add(new Sinhvien("2", "Nguyen Thi Minh"));
            SinhVienList.Add(new Sinhvien("3", "Nguyen Thi Minh"));
            SinhVienList.Add(new Sinhvien("4", "Nguyen Thi Minh"));
            SinhVienList.Add(new Sinhvien("5", "Nguyen Thi Minh"));
            SinhVienList.Add(new Sinhvien("6", "Nguyen Thi Minh"));


            MonHocList.Add( "1","Toan");
            MonHocList.Add("2","Li" );
            MonHocList.Add( "3","Hoa");
        }
    }
}
