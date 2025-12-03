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
    public partial class FormProductUs : UserControl
    {
        BL.Product pro = new BL.Product();


        public FormProductUs()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = pro.get_all_product();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
         dt  =pro.search_product(searchbox.Text);
         this.dataGridView1.DataSource = dt;

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف","عملية الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                pro.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت علمية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = pro.get_all_product();
            }
            else
            {
                MessageBox.Show("تمت الغاء الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void editProductbtn_Click(object sender, EventArgs e)
        {
            FormUpdateProduct up = new FormUpdateProduct();
            up.reftxt.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            up.discreptiontxt.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            up.quantitytxt.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            up.pricetxt.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            up.catgioresbox.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            up.reftxt.ReadOnly = true;
            
            byte[] img = (byte[])pro.get_img_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            up.pictureBox1.Image = Image.FromStream(ms);
            up.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            Formreviw fr = new Formreviw();
            byte[] img = (byte[])pro.get_img_product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            fr.pictureBox1.Image = Image.FromStream(ms);
            fr.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

       
        



      

    

      

        

    }
}
