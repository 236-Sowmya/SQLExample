using System;
using System.Data.SqlClient;

namespace SQLExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;database=NorthWind; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("select * from customers", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CompanyName"] + " " + sdr["Region"]);
                }
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something is wrong" + e);
            }
        }
    }
}
