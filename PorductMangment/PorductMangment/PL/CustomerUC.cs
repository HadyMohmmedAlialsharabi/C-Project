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
        public CustomerUC()
        {
            cust = new BL.Customerscs();

            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            byte[] imge = ms.ToArray();
            cust.add_customers(txtFirstName.Text,txtLastName.Text,txtTel.Text,txtEmail.Text,imge);
            MessageBox.Show("تم الاضافة بنجاح !");
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
            txtFirstName.Clear();
           txtLastName.Clear();
           txtEmail.Clear();
           txtTel.Clear();
           pbox.Image = null;
           txtFirstName.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
