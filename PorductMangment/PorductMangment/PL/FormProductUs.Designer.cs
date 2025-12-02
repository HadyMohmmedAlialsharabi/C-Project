namespace PorductMangment.PL
{
    partial class FormProductUs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editProductbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.imgbtn = new System.Windows.Forms.Button();
            this.nav = new System.Windows.Forms.Panel();
            this.titel1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title2 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nav.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editProductbtn
            // 
            this.editProductbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editProductbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editProductbtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductbtn.Location = new System.Drawing.Point(50, 338);
            this.editProductbtn.Name = "editProductbtn";
            this.editProductbtn.Size = new System.Drawing.Size(260, 50);
            this.editProductbtn.TabIndex = 12;
            this.editProductbtn.Text = "تعديل بيانات منتج";
            this.editProductbtn.UseVisualStyleBackColor = true;
            this.editProductbtn.Click += new System.EventHandler(this.editProductbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deletebtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(50, 400);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(260, 50);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "حذف المنتج المحدد";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addbtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(50, 276);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(260, 50);
            this.addbtn.TabIndex = 11;
            this.addbtn.Text = "اضافة منتج جديد";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(50, 518);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(260, 50);
            this.button8.TabIndex = 18;
            this.button8.Text = "الخروج";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // imgbtn
            // 
            this.imgbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imgbtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgbtn.Location = new System.Drawing.Point(50, 462);
            this.imgbtn.Name = "imgbtn";
            this.imgbtn.Size = new System.Drawing.Size(260, 50);
            this.imgbtn.TabIndex = 14;
            this.imgbtn.Text = "صورة المنتج";
            this.imgbtn.UseVisualStyleBackColor = true;
            this.imgbtn.Click += new System.EventHandler(this.imgbtn_Click);
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.Azure;
            this.nav.Controls.Add(this.titel1);
            this.nav.Controls.Add(this.button8);
            this.nav.Controls.Add(this.editProductbtn);
            this.nav.Controls.Add(this.addbtn);
            this.nav.Controls.Add(this.deletebtn);
            this.nav.Controls.Add(this.imgbtn);
            this.nav.Dock = System.Windows.Forms.DockStyle.Right;
            this.nav.Location = new System.Drawing.Point(1422, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(345, 710);
            this.nav.TabIndex = 19;
            // 
            // titel1
            // 
            this.titel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titel1.AutoSize = true;
            this.titel1.BackColor = System.Drawing.Color.DarkGray;
            this.titel1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titel1.Location = new System.Drawing.Point(139, 13);
            this.titel1.Name = "titel1";
            this.titel1.Padding = new System.Windows.Forms.Padding(20);
            this.titel1.Size = new System.Drawing.Size(224, 76);
            this.titel1.TabIndex = 2;
            this.titel1.Text = "العمليات المتاحة";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.title2);
            this.panel2.Controls.Add(this.searchbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 71);
            this.panel2.TabIndex = 20;
            // 
            // title2
            // 
            this.title2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title2.AutoSize = true;
            this.title2.BackColor = System.Drawing.Color.CadetBlue;
            this.title2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title2.Location = new System.Drawing.Point(1103, -4);
            this.title2.Name = "title2";
            this.title2.Padding = new System.Windows.Forms.Padding(20);
            this.title2.Size = new System.Drawing.Size(337, 66);
            this.title2.TabIndex = 1;
            this.title2.Text = "قم ب ادخال الكلمة المراد البحث عنها";
            this.title2.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(468, 11);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(599, 49);
            this.searchbox.TabIndex = 0;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.titel1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.nav;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 639);
            this.dataGridView1.TabIndex = 21;
            // 
            // FormProductUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nav);
            this.Name = "FormProductUs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1767, 710);
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button editProductbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button imgbtn;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label titel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}
