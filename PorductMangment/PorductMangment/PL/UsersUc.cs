using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PorductMangment.PL
{
    public partial class UsersUc : UserControl
    {
        BL.Users us = new BL.Users();
        public UsersUc()
        {
            InitializeComponent();
            dg3.DataSource = us.get_all_user();
            
        }

        private void infornationpa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (fullnametxt.Text== string.Empty ||passtxt.Text ==string.Empty ||usernametxt.Text ==string.Empty || verpastxt.Text==string.Empty)
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول ");
            }
            else
            {
                if (passtxt.Text==verpastxt.Text)
                {
                    us.add_user(usernametxt.Text, fullnametxt.Text, passtxt.Text, premisiomtxt.Text);
                    MessageBox.Show("  تمت الاضافة بكل نجاح ");
                    dg3.DataSource = us.get_all_user();

                    clear();
                }
                else
                {
                    MessageBox.Show("خطا ف التحقق من كلمة السر");
                    verpastxt.Focus();

                } 
                


            }
        }
        void clear()
        {
            fullnametxt.Text ="";
            passtxt.Text = "";
            usernametxt.Text ="";
            verpastxt.Text = "";
            premisiomtxt.Text = "";

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dg3.DataSource = us.search_user(searchtxt.Text);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (fullnametxt.Text == string.Empty || passtxt.Text == string.Empty || usernametxt.Text == string.Empty || verpastxt.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول ");
            }
            else
            {
                if (passtxt.Text == verpastxt.Text)
                {
                    us.Edit_user(usernametxt.Text, fullnametxt.Text, passtxt.Text, premisiomtxt.Text);
                    MessageBox.Show("  تمت التعديل بكل نجاح ");
                    clear();
                    dg3.DataSource = us.get_all_user();

                }
                else
                {
                    MessageBox.Show("خطا ف التحقق من كلمة السر");
                    verpastxt.Focus();

                }
            }
        }

        private void dg3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usernametxt.Text = dg3.CurrentRow.Cells[0].Value.ToString();
            passtxt.Text = dg3.CurrentRow.Cells[1].Value.ToString();
            premisiomtxt.Text = dg3.CurrentRow.Cells[2].Value.ToString();
            fullnametxt.Text = dg3.CurrentRow.Cells[3].Value.ToString();
        }

        private void deltebtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text==string.Empty)
            {
                MessageBox.Show("الحقل فارغ");
            }
            else
            {
                us.delete_from_users(usernametxt.Text);
                MessageBox.Show("تم الحذف بنجاح");
                dg3.DataSource = us.get_all_user();
                clear();

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

    
    } 
}
