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
    public partial class Add_Product_us : UserControl
    {
        BL.Product pro = new BL.Product();

        public Add_Product_us()
        {
            InitializeComponent();
            catgioresbox.DataSource = pro.get_all_categories();
            catgioresbox.DisplayMember = "DESCRIPTION";
            catgioresbox.ValueMember = "ID_CAT";


        }

        private void uploadebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.JPG; *.PNG; *.GIF ;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            pro.add_product(Convert.ToInt32(catgioresbox.SelectedValue), discreptiontxt.Text, reftxt.Text, Convert.ToInt32(quantitytxt.Text), pricetxt.Text, byteImage);
            MessageBox.Show("تمت الاضافة بنجاح  ","عملية الاضافة",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void reftxt_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pro.verfication_product_id(reftxt.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("  هذا المعرف موجود مسبقا  ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        } 

       
        
    }
}
