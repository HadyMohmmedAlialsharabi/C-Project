using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PorductMangment.BL
{
    class Users
    {

        public DataTable LOGIN(string ID,string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN", param);
            DAL.close();
            return dt;


        }
        public void add_user(string id, string fullname, string password, string usertype)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;
            param[2] = new SqlParameter("@password", SqlDbType.VarChar,50);
            param[2].Value = password;
            param[3] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[3].Value = usertype;
            dal.ExecuteCommand("add_user", param);
           
            dal.close();
        }
        public DataTable search_user(string search)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            dt = DAL.SelectData("search_user", param);
            DAL.close();
            return dt;


        }
        public void Edit_user(string id, string fullname, string password, string usertype)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[1].Value = fullname;
            param[2] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[2].Value = password;
            param[3] = new SqlParameter("@usertype", SqlDbType.VarChar, 50);
            param[3].Value = usertype;
            dal.ExecuteCommand("Edit_user", param);

            dal.close();
        }
        public DataTable get_all_user()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_all_user", null);
            DAL.close();
            return dt;


        }
        public void delete_from_users(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dal.ExecuteCommand("delete_from_users", param);
            dal.close();
        }
    }
}
