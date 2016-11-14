using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            //string maKh;
            //int maHd;
            //Console.WriteLine( "Nhap vao Ma Khach Hang:");
            //maKh = Console.ReadLine();
            
            //Console.WriteLine("Nhap vao Ma Hoa Don:");
            //maHd = Convert.ToInt16(Console.ReadLine());

            //SqlConnection myConn = new SqlConnection(ConfigurationSettings.AppSettings["strConn1"].ToString());
            //string selectString = "SELECT CustomerID, CompanyName FROM Customers WHERE CustomerID ='" + maKh + "'";
            //SqlCommand mySqlCommand = new SqlCommand(selectString, myConn);
            //SqlDataAdapter mySqlAdapter = new SqlDataAdapter(mySqlCommand);
            //DataSet myDataSet = new DataSet();
            //mySqlAdapter.Fill(myDataSet, "Customers");
            //selectString = "SELECT OrderID, CustomerID FROM Orders WHERE CustomerID ='" + maKh + "'";
            //mySqlCommand.CommandText = selectString;
            //mySqlAdapter.Fill(myDataSet, "Orders");
            //myDataSet.Relations.Add(
            //"Orders",
            //myDataSet.Tables["Customers"].Columns["CustomerID"],
            //myDataSet.Tables["Orders"].Columns["CustomerID"]);
            //DataTable customers = myDataSet.Tables["Customers"];
            //foreach (DataRow customer in customers.Rows)
            //{
            //    Console.WriteLine("CustomerID = " + customer["CustomerID"]);
            //    Console.WriteLine("CompanyName = " + customer["CompanyName"]);

            //    DataRow[] orders = customer.GetChildRows("Orders");
            //    Console.WriteLine("Oders of this customer:");
            //    foreach (DataRow order in orders)
            //    {
            //        Console.WriteLine("OrderID = " + order["OrderID"]);
            //    }
            //    myConn.Close();
            //}

            SqlConnection myConn = new SqlConnection(ConfigurationSettings.AppSettings["strConn1"].ToString());

            DataSet myDS = new DataSet();
            SqlDataAdapter CustomerAD = new SqlDataAdapter("Select * from Customers", myConn);
            SqlDataAdapter OrderdetailAd = new SqlDataAdapter("SELECT [Order Details].OrderID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, ([Order Details].Quantity*[Order Details].UnitPrice*(1-[Order Details].Discount)) as TotalPrice FROM[Order Details] INNER JOIN Products ON[Order Details].ProductID = Products.ProductID", myConn);

            CustomerAD.Fill(myDS, "Customers");
            OrderdetailAd.Fill(myDS, "OrderDetails");

            //Console.Write("Please input customer ID: ");
            //string cID = Console.ReadLine();

            //DataView myView = new DataView(myDS.Tables["Customers"]);
            //myView.RowFilter = "CustomerID = '" + cID + "'";
            //Console.WriteLine(myView[0][0].ToString() + "\t" + myView[0][1].ToString());

            Console.Write("Please input Order ID: ");
            string orderid = Console.ReadLine();
            DataView orderDV = new DataView(myDS.Tables["OrderDetails"]);
            orderDV.RowFilter = "OrderID = '" + orderid + "'";
            foreach (DataRowView order in orderDV)
            {
                Console.WriteLine(order[0].ToString() + "\t" + order[1].ToString() + "\t" + order[2].ToString()+"\t" + order[4].ToString());
            }
            //for (int i = 0; i < orderDV.Count; i++)
            //{

            //        Console.WriteLine(orderDV[i][0].ToString() + "\t" + orderDV[i][1].ToString() + "\t" + orderDV[i][2].ToString());

            //}
            Console.ReadLine();
        }
    }
}
