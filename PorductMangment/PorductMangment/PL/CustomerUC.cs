using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PorductMangment.PL
{
    public partial class CustomerUC : UserControl
    {
        BL.Customerscs cust;
        int positon,id;
        public CustomerUC()
        {
            cust = new BL.Customerscs();
            
            InitializeComponent();
            dgList.DataSource = cust.get_all_customers();
            dgList.Columns[0].Visible = false;
            dgList.Columns[5].Visible = false;
        }

        void clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            pbox.Image = null;
        }
        

        private void addbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            byte[] imge = ms.ToArray();
            cust.add_customers(txtFirstName.Text,txtLastName.Text,txtTel.Text,txtEmail.Text,imge);
            MessageBox.Show("تم الاضافة بنجاح !");
            dgList.DataSource = cust.get_all_customers();
            clear();

            addbtn.Enabled = false;
            newbtn.Enabled = true;
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF ;";
            if (op.ShowDialog()==DialogResult.OK)
            {
                pbox.Image = Image.FromFile(op.FileName);   
            }

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            clear();
           txtFirstName.Focus();
           addbtn.Enabled = true;
           newbtn.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       

        private void dgList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFirstName.Text = dgList.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgList.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dgList.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgList.CurrentRow.Cells[4].Value.ToString();
            byte[] img = (byte[])dgList.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pbox.Image = Image.FromStream(ms);

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            byte[] imge = ms.ToArray();
            cust.edit_customers(Convert.ToInt16(dgList.CurrentRow.Cells[0].Value),txtFirstName.Text, txtLastName.Text, txtTel.Text, txtEmail.Text, imge);
            MessageBox.Show("تم التعديل  بنجاح !");
            dgList.DataSource = cust.get_all_customers();
            clear();

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل انت متاكد من عملية الحذف","الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                cust.DeleteProduct(Convert.ToInt16(dgList.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الحذف  بنجاح !");
                dgList.DataSource = cust.get_all_customers(); 

            }
            clear();

            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dgList.DataSource = cust.search_customers(txtSearch.Text);

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode== Keys.Enter)
            {
                searchbtn_Click(sender, e);

            }

            
        }
        void Navigate(int index)
        {
            pbox.Image = null;
            DataTable dt = cust.get_all_customers();
            DataRowCollection drc = dt.Rows;
            id = Convert.ToInt16( drc[index][0]);
            txtFirstName.Text = drc[index][1].ToString();
            txtLastName.Text = drc[index][2].ToString();
            txtTel.Text = drc[index][3].ToString();
            txtEmail.Text = drc[index][4].ToString();
           byte[] img = (byte[])dt.Rows[index][5];
           MemoryStream ms = new MemoryStream(img);
           pbox.Image = Image.FromStream(ms);


        }

        private void firstbtn_Click(object sender, EventArgs e)
        {
            Navigate(0);
            positon = 0;
            lblPosition.Text =( positon+1 )+ "/" + positon ;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            positon = cust.get_all_customers().Rows.Count - 1;
            Navigate(positon);
            lblPosition.Text = (positon+1) + "/" + positon ;

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (positon == 0)
            {
                return;
            }
            positon -= 1;
            Navigate(positon);
            lblPosition.Text = (positon + 1) + "/" + positon;

        }

        private void previosbtn_Click(object sender, EventArgs e)
        {
            
                if (positon == cust.get_all_customers().Rows.Count - 1)
                {
                    return;
                }
                positon += 1;
                Navigate(positon);
                lblPosition.Text = (positon + 1) + "/" + positon;
          
        }

       
        

        

   
    }
}
