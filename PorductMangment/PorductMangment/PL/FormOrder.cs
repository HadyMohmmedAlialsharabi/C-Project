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
        DataTable dt=new DataTable();
        public FormOrder()
        {
            InitializeComponent();
            create_datatable();
            salesnametxt.Text = Program.fullname;
        }
        void create_datatable()
        {
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dt.Columns.Add("");
            dataGridView1.DataSource = dt;

        }

       


        private void newOrderbtn_Click(object sender, EventArgs e)
        {
            idOrdertxt.Text = order.get_last_order().Rows[0][0].ToString();
            newOrderbtn.Enabled = false;
            saveOrderbtn.Enabled = true;
            OrderDiscreptiontxt.Focus();
        }

        private void choisCoustomerbtn_Click(object sender, EventArgs e)
        {
            form_coustomer_list fcl = new form_coustomer_list();
            fcl.ShowDialog();
            customeridtxt.Text = fcl.dg1.CurrentRow.Cells[0].Value.ToString();
          Fnametxt.Text = fcl.dg1.CurrentRow.Cells[1].Value.ToString();
           Lnametxt.Text = fcl.dg1.CurrentRow.Cells[2].Value.ToString();
           teltxt.Text = fcl.dg1.CurrentRow.Cells[3].Value.ToString();
           emailtxt.Text = fcl.dg1.CurrentRow.Cells[4].Value.ToString();
           byte[]  picture =(byte[])fcl.dg1.CurrentRow.Cells[5].Value;
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void choisproductbtn_Click(object sender, EventArgs e)
        {
            form_product_listcs fps = new form_product_listcs();
            fps.ShowDialog();
            ptxtid.Text = fps.dg2.CurrentRow.Cells[0].Value.ToString();
           pnametxt.Text = fps.dg2.CurrentRow.Cells[1].Value.ToString();

           pprictxt.Text = fps.dg2.CurrentRow.Cells[3].Value.ToString();
           pquantitytxt.Focus();
        }

        private void pquantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            
        }

        private void pdicounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pquantitytxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (pprictxt.Text!= string.Empty && pquantitytxt.Text != string.Empty)
            {


                int price = Convert.ToInt16(pprictxt.Text);
                int quatity = Convert.ToInt16(pquantitytxt.Text);
                ptotalpricetxt.Text = Convert.ToString(price * quatity);
            }
        }

        private void pdicounttxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (pprictxt.Text != string.Empty && pquantitytxt.Text != string.Empty && pdicounttxt.Text != string.Empty)
            {
                double discount = Convert.ToDouble(pdicounttxt.Text);
                int totalprice = Convert.ToInt32(ptotalpricetxt.Text);
                double totalPriceAfter = totalprice - (totalprice * (discount / 100));
                ptotalaftertxt.Text = totalPriceAfter.ToString();


                
            }
        }

        private void pdicounttxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                DataRow r = dt.NewRow();
                r[0] = ptxtid.Text;
                r[1] =pnametxt.Text;
                r[2] =pprictxt.Text;
                r[3] =pquantitytxt.Text;
                r[4] = ptotalpricetxt.Text;
                r[5] = pdicounttxt.Text;
                r[6] = ptotalaftertxt.Text;
                finalyTotaltxt.Text = (Convert.ToInt16(finalyTotaltxt.Text) + Convert.ToInt16(ptotalaftertxt.Text)).ToString();
                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;
                clear();
                newOrderbtn.Focus();

                

            }
        }
        void clear()
        {
             ptxtid.Text="";
             pnametxt.Text = "";
             pprictxt.Text = "";
             pquantitytxt.Text = "";
             ptotalpricetxt.Text = "";
             pdicounttxt.Text = "";
             ptotalaftertxt.Text = "";
        }

        private void saveOrderbtn_Click(object sender, EventArgs e)
        {
            order.add_order(Convert.ToInt16(idOrdertxt.Text)
                , dateOrdertxt.Value, Convert.ToInt16(customeridtxt.Text)
                , OrderDiscreptiontxt.Text ,salesnametxt.Text);

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                order.add_order_ditails(dataGridView1.Rows[i].Cells[0].Value.ToString()
                    ,Convert.ToInt16(idOrdertxt.Text),
                   Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)
                    , dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt16(dataGridView1.Rows[i].Cells[5].Value)
                    ,dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString());
            }


            MessageBox.Show(" تمت عملية الحفظ بنجاح");
        }
    }
}
