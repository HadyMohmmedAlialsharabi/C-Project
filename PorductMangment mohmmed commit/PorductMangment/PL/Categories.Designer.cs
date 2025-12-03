namespace PorductMangment.PL
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rightbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.dleftbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.leftbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.drightbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.discreptiontxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lpPosition = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dleftbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drightbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Controls.Add(this.deletebtn);
            this.groupBox1.Controls.Add(this.newbtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1495, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(268, 826);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات المتاحة";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(12, 509);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 48);
            this.button5.TabIndex = 4;
            this.button5.Text = "عودة";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Enabled = false;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addbtn.Location = new System.Drawing.Point(12, 329);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(244, 48);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "اضافة ";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editbtn.Location = new System.Drawing.Point(12, 389);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(244, 48);
            this.editbtn.TabIndex = 2;
            this.editbtn.Text = "تعديل";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deletebtn.Location = new System.Drawing.Point(12, 449);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(244, 48);
            this.deletebtn.TabIndex = 1;
            this.deletebtn.Text = "حذف";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newbtn.Location = new System.Drawing.Point(12, 269);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(244, 48);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "جديد";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lpPosition);
            this.groupBox2.Controls.Add(this.rightbtn);
            this.groupBox2.Controls.Add(this.dleftbtn);
            this.groupBox2.Controls.Add(this.leftbtn);
            this.groupBox2.Controls.Add(this.drightbtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.discreptiontxt);
            this.groupBox2.Controls.Add(this.idtxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1495, 410);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصنف";
            // 
            // rightbtn
            // 
            this.rightbtn.BackColor = System.Drawing.Color.Transparent;
            this.rightbtn.Image = ((System.Drawing.Image)(resources.GetObject("rightbtn.Image")));
            this.rightbtn.ImageActive = null;
            this.rightbtn.Location = new System.Drawing.Point(528, 255);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(100, 94);
            this.rightbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightbtn.TabIndex = 14;
            this.rightbtn.TabStop = false;
            this.rightbtn.Zoom = 10;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // dleftbtn
            // 
            this.dleftbtn.BackColor = System.Drawing.Color.Transparent;
            this.dleftbtn.Image = ((System.Drawing.Image)(resources.GetObject("dleftbtn.Image")));
            this.dleftbtn.ImageActive = null;
            this.dleftbtn.Location = new System.Drawing.Point(839, 246);
            this.dleftbtn.Name = "dleftbtn";
            this.dleftbtn.Size = new System.Drawing.Size(131, 122);
            this.dleftbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dleftbtn.TabIndex = 13;
            this.dleftbtn.TabStop = false;
            this.dleftbtn.Zoom = 10;
            this.dleftbtn.Click += new System.EventHandler(this.dleftbtn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.BackColor = System.Drawing.Color.Transparent;
            this.leftbtn.Image = ((System.Drawing.Image)(resources.GetObject("leftbtn.Image")));
            this.leftbtn.ImageActive = null;
            this.leftbtn.Location = new System.Drawing.Point(714, 246);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(119, 122);
            this.leftbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftbtn.TabIndex = 12;
            this.leftbtn.TabStop = false;
            this.leftbtn.Zoom = 10;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // drightbtn
            // 
            this.drightbtn.BackColor = System.Drawing.Color.Transparent;
            this.drightbtn.Image = ((System.Drawing.Image)(resources.GetObject("drightbtn.Image")));
            this.drightbtn.ImageActive = null;
            this.drightbtn.Location = new System.Drawing.Point(409, 255);
            this.drightbtn.Name = "drightbtn";
            this.drightbtn.Size = new System.Drawing.Size(100, 94);
            this.drightbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drightbtn.TabIndex = 11;
            this.drightbtn.TabStop = false;
            this.drightbtn.Zoom = 10;
            this.drightbtn.Click += new System.EventHandler(this.drightbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "وصف الصنف";
            // 
            // discreptiontxt
            // 
            this.discreptiontxt.Location = new System.Drawing.Point(442, 125);
            this.discreptiontxt.Multiline = true;
            this.discreptiontxt.Name = "discreptiontxt";
            this.discreptiontxt.Size = new System.Drawing.Size(432, 96);
            this.discreptiontxt.TabIndex = 2;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(442, 39);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(432, 41);
            this.idtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "معرف الصنف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(20);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1495, 416);
            this.dataGridView1.TabIndex = 22;
            // 
            // lpPosition
            // 
            this.lpPosition.AutoSize = true;
            this.lpPosition.Location = new System.Drawing.Point(650, 292);
            this.lpPosition.Name = "lpPosition";
            this.lpPosition.Size = new System.Drawing.Size(58, 34);
            this.lpPosition.TabIndex = 15;
            this.lpPosition.Text = "6/7";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(1763, 826);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dleftbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drightbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discreptiontxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button newbtn;
        private Bunifu.Framework.UI.BunifuImageButton rightbtn;
        private Bunifu.Framework.UI.BunifuImageButton dleftbtn;
        private Bunifu.Framework.UI.BunifuImageButton leftbtn;
        private Bunifu.Framework.UI.BunifuImageButton drightbtn;
        private System.Windows.Forms.Label lpPosition;
    }
}
