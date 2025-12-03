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
    }
}
