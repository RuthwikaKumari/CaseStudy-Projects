using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MessageEntities;
using System.ComponentModel;


namespace MessageDAL
{
    public class DAL
    {
        public bool LoginUser(Parent prnt)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from tbl_parent where ParentName=@username and Password=@password", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", prnt.ParentName);
                cmd.Parameters.AddWithValue("@password", prnt.Password);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public bool UserNameExists(string username)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from tbl_parent where ParentName=@username", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
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
        public void RegisterUser(Parent prnt)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("insert into tbl_parent values (@name,@pswd)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", prnt.ParentName);
                cmd.Parameters.AddWithValue("@pswd", prnt.Password);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally 
            {
                con.Close();
            }  
        }
        public void PostMessage(Message msg)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("insert into tbl_messages values (@pn,@sub,@msg)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pn", msg.ParentName);
                cmd.Parameters.AddWithValue("@sub", msg.Subject);
                cmd.Parameters.AddWithValue("@msg", msg.message);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }
        public List<Message> GetMessagesBySubject(string subject)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                List<Message> lstmsgs = new List<Message>();
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from tbl_messages where Subject = @sub", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sub", subject);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Message msg = null;
                while (sdr.Read())
                {
                    msg = new Message
                    {
                        Id= (int)sdr[0],
                        ParentName = sdr[1].ToString(),
                        Subject = sdr[2].ToString(),
                        message = sdr[3].ToString(),
                    };
                    lstmsgs.Add(msg);
                }
                return lstmsgs;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }            
        }
        public List<Message> GetAllSubjects()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                List<Message> lstmsg = new List<Message>();
                con.ConnectionString = @"Data Source=IN-5CG0253H0K\GDATA2014;Initial Catalog=DXCDB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select distinct Subject from tbl_messages", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Message msg = null;
                while (sdr.Read())
                {
                    msg = new Message
                    {
                        Subject = sdr[0].ToString(),
                    };
                    lstmsg.Add(msg);
                }
                return lstmsg;
            }
            catch(SqlException ex)
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
