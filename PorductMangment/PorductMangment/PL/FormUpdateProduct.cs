using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PorductMangment.PL
{
   
    public partial class FormUpdateProduct : Form
    {
        BL.Product pro; 
        public FormUpdateProduct()
        {
            pro = new BL.Product();
            InitializeComponent();
        }

        

        

        private void updatebtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] byteImage = ms.ToArray();
            pro.updateProduct(Convert.ToInt32(catgioresbox.SelectedValue), discreptiontxt.Text, reftxt.Text, Convert.ToInt32(quantitytxt.Text), pricetxt.Text, byteImage);
            MessageBox.Show("تم التعديل  بنجاح  ", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        

        }



        

       

   
    }
}
