using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PorductMangment.BL
{
    class ORDERS
    {

        public DataTable get_last_order()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_last_order", null);
            DAL.close();
            return dt;


        }
        public void add_order(int id_order, DateTime date_order
            , int  id_customer,string description, string salesmane)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[4];
           
            param[0] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[0].Value = date_order;
            param[1] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[1].Value =id_customer;
            param[2] = new SqlParameter("@description_order", SqlDbType.VarChar, 250);
            param[2].Value = description;
            param[3] = new SqlParameter("@salesman", SqlDbType.VarChar,75);
            param[3].Value = salesmane;
            dal.ExecuteCommand("add_order", param);
            dal.close();
        }


         public void add_order_ditails(string id_product,int id_order, int quantity, string price, float discount, string amount,string total_amount)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];
           
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar,50);
            param[0].Value = id_product;
            param[1] = new SqlParameter("@id_order", SqlDbType.Int);
            param[1].Value =id_order;
            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar,30);
            param[3].Value = price;
            param[4] = new SqlParameter("@discount", SqlDbType.Float);
            param[4].Value = discount;
            param[5] = new SqlParameter("@amount", SqlDbType.VarChar,50);
            param[5].Value = amount;
            param[6] = new SqlParameter("@total_amount", SqlDbType.VarChar,50);
            param[6].Value = total_amount;

            dal.ExecuteCommand("add_order_ditails", param);
            dal.close();
        
        }

    }
}
