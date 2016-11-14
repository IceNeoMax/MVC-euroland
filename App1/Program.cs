using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getinfo, tage;
            string tname, tmsv;
            //Data.Khoitao();
            SqlConnection myConn = new SqlConnection(ConfigurationSettings.AppSettings["strConn1"].ToString());
            
                
                // 1. tao connect
                //2 tao command
                //3 mo connect
                //4 truy van
                //5 dong connect
                //Console.WriteLine("nhap ma sv:"); string pma = Convert.ToString(Console.ReadLine());
                //Console.WriteLine("nhap ten sv:"); string pten = Convert.ToString(Console.ReadLine());
                //Console.WriteLine("nhap tuoi sv:"); int ptuoi = Convert.ToInt16(Console.ReadLine());
                //myConn.Open();
                //SqlCommand InsertSv = new SqlCommand("INSERT into Sinhvien values('"+pma+"','"+pten+"',"+ptuoi+")",myConn);
                //InsertSv.ExecuteNonQuery();
                //Console.WriteLine("done");
                //myConn.Close();
                //myConn.Open();
                //DataSet Bai1DS = new DataSet();
                //SqlDataAdapter SvAd = new SqlDataAdapter("SELECT * FROM Sinhvien", myConn);
                //SvAd.Fill(Bai1DS,"Sinhvien");
                
                ////Bai1DS.Tables["Sinhvien"].Rows[1][1] = "999";
                //SqlCommandBuilder myB = new SqlCommandBuilder(SvAd);
                //SvAd.Update(Bai1DS,"Sinhvien");
                ////Bai1DS.Tables[0].Rows[1].Delete();
                ////SvAd.Update(Bai1DS, "Sinhvien");
                //DataRow trow;
                //trow = Bai1DS.Tables[0].NewRow();
                
                //trow[1] = "Sv00";
                //trow[2] = "Fuck this shit";
                //trow[3] = 20;
                //Bai1DS.Tables[0].Rows.Add(trow);
                //SvAd.Update(Bai1DS, "Sinhvien");
                //for (int i = 0; i < Bai1DS.Tables["Sinhvien"].Rows.Count; i++)
                //{
                //    Console.WriteLine(Bai1DS.Tables["Sinhvien"].Rows[i][1]);
                //}
                
                //SqlDataReader myReader;
                //SqlCommand Readsv = new SqlCommand("SELECT * FROM Sinhvien",myConn);
                //myReader = Readsv.ExecuteReader();
                //while(myReader.Read()){
                //    Console.WriteLine(myReader[0]+" "+myReader[2]);
                //}

                //myConn.Close();


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
                        Console.Write("Nhap ma sinh viên:");
                        tmsv = Convert.ToString(Console.ReadLine());
                        Console.Write("Nhap ten sinh viên:");
                        tname = Convert.ToString(Console.ReadLine());
                        Console.Write("Nhap ten tuoi viên:");
                        tage = Convert.ToInt16(Console.ReadLine());
                        //Data.SinhVienList.Add(new Sinhvien(tmsv, tname));
                        myConn.Open();
                        SqlCommand InsertSv = new SqlCommand("INSERT into Sinhvien values('" + tmsv + "','" + tname + "'," + tage + ")", myConn);
                        InsertSv.ExecuteNonQuery();
                        Console.WriteLine("done");
                        myConn.Close();
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
                        Data.MonHocList.Add(tmsv, tname);
                       // InTenMh();
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

        //private static void InTenSv()
        //{
        //    foreach (Sinhvien item in Data.SinhVienList)
        //    {
        //        Console.WriteLine(item.Ten);
        //    }
        //}
        //private static void InTenMh()
        //{
        //    foreach (Object item in Data.MonHocList.Values)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
       
        
    }
}
