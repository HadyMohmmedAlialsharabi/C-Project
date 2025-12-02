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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            mainPa.Controls.Clear();
            CustomerUC cu = new CustomerUC();
            cu.Dock = DockStyle.Fill;
            mainPa.Controls.Add(cu);
        }
    }
}
