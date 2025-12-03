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
    public partial class FormOrder : UserControl
    {
        BL.ORDERS order = new BL.ORDERS();
        public FormOrder()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            billIDtxt.Text = order.get_last_order().Rows[0][0].ToString();
            newOrderbtn.Enabled = false;
            saveOrderbtn.Enabled = true;
            billdiscreptiontxt.Focus();
        }

        private void choisCoustomerbtn_Click(object sender, EventArgs e)
        {
            form_coustomer_list fcl = new form_coustomer_list();
            fcl.Show();
            IDtxt.Text = fcl.dataGridView1.CurrentRow.Cells[0].Value.ToString();
          Fnametxt.Text = fcl.dataGridView1.CurrentRow.Cells[1].Value.ToString();
           Lnametxt.Text = fcl.dataGridView1.CurrentRow.Cells[2].Value.ToString();
           teltxt.Text = fcl.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           emailtxt.Text = fcl.dataGridView1.CurrentRow.Cells[4].Value.ToString();
           byte[]  picture =(byte[])fcl.dataGridView1.CurrentRow.Cells[5].Value;
           MemoryStream ms = new MemoryStream(picture);
           pictureBox1.Image = Image.FromStream(ms);



            
        }

        private void Fnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
