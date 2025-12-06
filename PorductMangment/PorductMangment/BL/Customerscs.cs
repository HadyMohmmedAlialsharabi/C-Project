using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PorductMangment.BL
{
    class Customerscs
    {


        public void add_customers(string f_name, string l_name,  string tel, string email, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@f_name", SqlDbType.VarChar,25);
            param[0].Value = f_name;
            param[1] = new SqlParameter("@l_name", SqlDbType.VarChar, 25);
            param[1].Value = l_name;
            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;
            param[3] = new SqlParameter("@email", SqlDbType.VarChar,25);
            param[3].Value = email;
            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;
            dal.ExecuteCommand("ADD_CUSTOMER", param);
            dal.close();
        }
        public DataTable verfication_product_id(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("verficationProductId", param);
            DAL.close();
            return dt;


        }
        public DataTable get_all_customers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_all_customers", null);
            DAL.close();
            return dt;


        }
        public void edit_customers(int id,string f_name, string l_name, string tel, string email, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@f_name", SqlDbType.VarChar, 25);
            param[0].Value = f_name;
            param[1] = new SqlParameter("@l_name", SqlDbType.VarChar, 25);
            param[1].Value = l_name;
            param[2] = new SqlParameter("@tel", SqlDbType.NChar, 15);
            param[2].Value = tel;
            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[3].Value = email;
            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;
            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Value = id;
            dal.ExecuteCommand("EDIT_CUSTOMER", param);
            dal.close();
        }

        public void DeleteProduct(int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dal.ExecuteCommand("DELETE_CUSTOMER", param);
            dal.close();
        }
        public DataTable search_customers(string word)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0]  = new SqlParameter("@word",SqlDbType.VarChar,50);
            param[0].Value = word;
            DataTable dt = new DataTable( );
            dt = DAL.SelectData("search_Customers", param);
            DAL.close();
            return dt;


        }
    }

}
