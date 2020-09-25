using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageEntities;
using MessageDAL;

namespace MessageBussinessLayer
{
    public class BussinessLayer
    {
        public bool LoginUser(Parent prnt)
        {
            try
            {
                DAL dal = new DAL();
                bool value = dal.LoginUser(prnt);
                return value;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void RegisterUser(Parent prnt)
        {
            try 
            { 
            DAL dal = new DAL();
            dal.RegisterUser(prnt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool UserNameExists(string username)
        {
            try
            {
                DAL dal = new DAL();
                bool value = dal.UserNameExists(username);
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void PostMessage(Message msg)
        {
            try
            {
                DAL dal = new DAL();
                dal.PostMessage(msg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Message> GetMessagesBySubject(string subject)
        {
            try
            {
                DAL dal = new DAL();
                List<Message> msg = dal.GetMessagesBySubject(subject);
                return msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Message> GetAllSubjects()
        {
            try
            {
                DAL dal = new DAL();
                List<Message> msg = dal.GetAllSubjects();
                return msg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
