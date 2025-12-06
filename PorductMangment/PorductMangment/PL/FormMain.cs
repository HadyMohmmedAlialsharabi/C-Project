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
    
    public partial class FormMain : Form
    {
        private static FormMain main;
        static void form_close(object sender ,FormClosedEventArgs e)
        {
            main = null;
        }
        public static FormMain getMainForm
        {
            get
            {
                if (main == null)
                {
                    main = new FormMain();
                    main.FormClosed += new FormClosedEventHandler(form_close);
                    
                }
                return main;
            }
        }
        public FormMain()
        {
            if (main == null)
            {
                main = this;
            }
            InitializeComponent();
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormLogin login = new FormLogin();
           // login.ShowDialog();

            mainpa.Controls.Clear();
            LoginUc login = new LoginUc();
            login.Dock = DockStyle.Fill;
            mainpa.Controls.Add(login);
        }

        private void اضافهمنتججToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            Add_Product_us adp = new Add_Product_us();
            adp.Dock = DockStyle.Fill;
            mainpa.Controls.Add(adp);
            
            
            
            

        }

        private void يToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            FormProductUs pr = new FormProductUs();
            pr.Dock = DockStyle.Fill;
            mainpa.Controls.Add(pr);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void اضافهصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            Categories cat = new Categories();
            cat.Dock = DockStyle.Fill;
            mainpa.Controls.Add(cat);
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            CustomerUC cu = new CustomerUC();
            cu.Dock = DockStyle.Fill;
            mainpa.Controls.Add(cu);
        }

        private void ملفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            FormOrder fo = new FormOrder();
            fo.Dock = DockStyle.Fill;
            mainpa.Controls.Add(fo);
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpa.Controls.Clear();
            UsersUc us = new UsersUc();
            us.Dock = DockStyle.Fill;
            mainpa.Controls.Add(us);
        }

    

       
    } 
}
