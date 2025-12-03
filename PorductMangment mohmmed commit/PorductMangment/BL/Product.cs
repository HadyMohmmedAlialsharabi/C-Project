using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PorductMangment.BL
{
    class Product
    {
        public DataTable get_all_categories()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
 
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_all_categories", null);
            DAL.close();
            return dt;


        }
        public void add_product(int id_cat ,string label ,string id_product,int quantity,string price,byte [] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT",SqlDbType.Int);
            param[0].Value = id_cat;
            param[1] = new SqlParameter("@ID_PRODUCT",SqlDbType.VarChar,50);
            param[1].Value = id_product;
            param[2] = new SqlParameter("@LABEL", SqlDbType.VarChar,50);
            param[2].Value = label;
            param[3] = new SqlParameter("@QUANTITY", SqlDbType.Int);
            param[3].Value = quantity;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[4].Value = price;
            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;
            dal.ExecuteCommand("ADD_PRODUCT", param);
            dal.close();
        }
        public DataTable verfication_product_id(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            dt = DAL.SelectData("verficationProductId", param);
            DAL.close();
            return dt;


        }
        public DataTable get_all_product()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("getAllPrudoct", null);
            DAL.close();
            return dt;


        }

        public DataTable search_product(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("SearchProduct", param);
            DAL.close();
            return dt;


        }
        public DataTable get_img_product(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.SelectData("get_img_product", param);
            DAL.close();
            return dt;


        }
        public void DeleteProduct(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value = id;

            dal.ExecuteCommand("DeleteProduct", param);
            dal.close();
        }
        public void updateProduct(int id_cat, string label, string id_product, int quantity, string price, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = id_cat;
            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 50);
            param[1].Value = id_product;
            param[2] = new SqlParameter("@LABEL", SqlDbType.VarChar, 50);
            param[2].Value = label;
            param[3] = new SqlParameter("@QUANTITY", SqlDbType.Int);
            param[3].Value = quantity;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = price;
            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;
            dal.ExecuteCommand("updateProduct", param);
            dal.close();
            
        }
        
    }
}
