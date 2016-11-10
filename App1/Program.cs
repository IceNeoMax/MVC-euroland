using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getinfo;
            string tname, tmsv;
            Data.Khoitao();


            Console.WriteLine("1. Nhap them sinh viên");
            Console.WriteLine("2. Sua thông tin sinh viên");
            Console.WriteLine("3. Thêm môn hoc");
            Console.WriteLine("4. Sua thông tin môn hoc");
            Console.WriteLine("5. Nhap điem");
            Console.WriteLine("6. thoat");
            //(Environment.Exit)
            getinfo = Convert.ToInt16(Console.ReadLine());
            switch (getinfo)
            {
                case 1:
                    Console.WriteLine("1. Nhap them sinh viên");
                    Console.Write("Nhap ten sinh viên:");
                    tname = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap ma sinh viên:");
                    tmsv = Convert.ToString(Console.ReadLine());
                    Data.SinhVienList.Add(new Sinhvien(tmsv, tname));
                    InTenSv();
                    break;
                case 2:
                    Console.WriteLine("2. Sua thông tin sinh viên");
                    break;
                case 3:
                    Console.WriteLine("3. Thêm môn hoc");
                    Console.Write("Nhap ten mon hoc:");
                    tname = Convert.ToString(Console.ReadLine());
                    Console.Write("Nhap ma mon hoc:");
                    tmsv = Convert.ToString(Console.ReadLine());
                    Data.MonHocList.Add(tmsv,tname );
                    InTenMh();
                    break;
                case 4:
                    Console.WriteLine("4. Sua thông tin môn hoc");
                    break;
                case 5:
                    Console.WriteLine("5. Nhap điem");
                    break;
                case 6:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            //InTenSv();
        }

        private static void InTenSv()
        {
            foreach (Sinhvien item in Data.SinhVienList)
            {
                Console.WriteLine(item.Ten);
            }
        }
        private static void InTenMh()
        {
            foreach (Object item in Data.MonHocList.Values)
            {
                Console.WriteLine(item);
            }
        }
       
        
    }
}
