using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PorductMangment.PL
{
    public partial class Categories : UserControl
    {
        SqlConnection conn = new SqlConnection("Server=HADYSE1000; Database=Product_DB; Trusted_Connection=True");
        SqlDataAdapter da;
        DataTable dt =new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public Categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("SELECT ID_CAT as 'المعرف' ,DESCRIPTION as 'الصنف' FROM CATEGORIS",conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            idtxt.DataBindings.Add("text", dt, "المعرف");
            discreptiontxt.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            lpPosition.Text = (bmb.Position +1)+ "/" + bmb.Count; 
            
        }

        private void dleftbtn_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 

        }

        private void drightbtn_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 

        }

        private void leftbtn_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 
      
        }

        private void rightbtn_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 
      

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            newbtn.Enabled = false;
            addbtn.Enabled = true;
            int id =Convert.ToInt16( dt.Rows[dt.Rows.Count - 1][0])+1;
            idtxt.Text = id.ToString();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show(" تمت الاضافة بنجاح");
            addbtn.Enabled = false;
            newbtn.Enabled = true;
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show(" تمت التعديل بنجاح");
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 


        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show(" تمت الحذف بنجاح");
            lpPosition.Text = (bmb.Position + 1) + "/" + bmb.Count; 

        }


     

        
    }
}
