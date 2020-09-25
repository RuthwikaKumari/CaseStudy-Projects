using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntities;
using System.Data.SqlClient;
using System.Data;

namespace JuiceShopDal
{
    public class Juiceshopdal
    {
        public List<Juice> GetJuiceFlavors()
        {
            List<Juice> lstjuices = new List<Juice>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from Juice", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Juice jc = new Juice
                {
                    juice_id = (int)sdr[0],
                    juice_flavor = sdr[1].ToString(),
                    price = (int)sdr[2]
                };
                lstjuices.Add(jc);
            }
            con.Close();
            return lstjuices;
        }
        public void JuicePurchased(int juice_id, int quantity)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("insert into JuicePurchased(juice_id,quantity) values(@j_id,@qnty)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@j_id", juice_id);
                cmd.Parameters.AddWithValue("@qnty", quantity);
                SqlCommand cmd1 = new SqlCommand("update JuicePurchased set JuicePurchased.amount= jp.quantity * j.price from JuicePurchased jp inner join Juice j on jp.juice_id = j.juice_id", con);
                cmd1.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public List<JuicePurchased> GetJuicePurchased()
        {
            List<JuicePurchased> lstjucpur = new List<JuicePurchased>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from JuicePurchased", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                JuicePurchased jp = new JuicePurchased
                {
                    purchase_no = (int)sdr[0],
                    juice_id = (int)sdr[1],
                    quantity = (int)sdr[2],
                    amount = (int)sdr[3]
                };
                lstjucpur.Add(jp);
            }
            con.Close();
            return lstjucpur;
        }
        public void DeleteRecords()
        {
            SqlConnection con = new SqlConnection();
            try 
            { 
            con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("delete from JuicePurchased", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            con.Open();
            cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
