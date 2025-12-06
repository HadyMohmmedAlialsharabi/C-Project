using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorductMangment.PL
{
    public partial class form_coustomer_list : Form
    {
        BL.Customerscs cust = new BL.Customerscs();
        public form_coustomer_list()
        {
            InitializeComponent();
            dg1.DataSource = cust.get_all_customers();
            dg1.Columns[0].Visible = false;
            dg1.Columns[5].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
