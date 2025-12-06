using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PorductMangment.PL
{
    public partial class LoginUc : UserControl
    {
        BL.Users log = new BL.Users();
        public LoginUc()
        {
            InitializeComponent();
        }
        private void loginbtn_Click_1(object sender, EventArgs e)
        {


            DataTable dt = log.LOGIN(nametxt.Text, passtxt.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(" login Sucessfuly");
                PL.FormMain main = new PL.FormMain( );
                if (dt.Rows[0][2].ToString()=="مدير")
                {
                    PL.FormMain.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.المستخدمينToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Program.fullname = dt.Rows[0]["FULLNAME"].ToString();
                    this.Hide();   
                }
                else
                {
                    PL.FormMain.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.المنتجاتToolStripMenuItem.Enabled = true;
                    PL.FormMain.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    Program.fullname = dt.Rows[0]["FULLNAME"].ToString();
                    this.Hide();  
                }
                
                

            }
            else
            {
                MessageBox.Show(" login filed !");
            }
        }

        private void exitbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }
        


      

       
        
    }
}
