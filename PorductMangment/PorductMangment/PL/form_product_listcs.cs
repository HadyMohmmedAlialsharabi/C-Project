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
    public partial class form_product_listcs : Form
    {
        BL.Product pro = new BL.Product();
        public form_product_listcs()
        {
            InitializeComponent();
        }

        private void form_product_listcs_Load(object sender, EventArgs e)
        {

           dg2.DataSource= pro.get_all_product();
        }

        private void dg2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
