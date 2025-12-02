namespace PorductMangment.PL
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPa = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mainPa
            // 
            this.mainPa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPa.Location = new System.Drawing.Point(0, 0);
            this.mainPa.Name = "mainPa";
            this.mainPa.Size = new System.Drawing.Size(1101, 755);
            this.mainPa.TabIndex = 0;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 755);
            this.Controls.Add(this.mainPa);
            this.Name = "test";
            this.Text = "test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPa;
    }
}