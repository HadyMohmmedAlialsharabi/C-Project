namespace PorductMangment.PL
{
    partial class FormOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveOrderbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newOrderbtn = new System.Windows.Forms.Button();
            this.choisCoustomerbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salesnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOrdertxt = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderDiscreptiontxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idOrdertxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customeridtxt = new System.Windows.Forms.TextBox();
            this.Lnametxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Fnametxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.choisproductbtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ptotalaftertxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pdicounttxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ptotalpricetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pquantitytxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pprictxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ptxtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalyTotaltxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.saveOrderbtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.newOrderbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1584, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 913);
            this.panel2.TabIndex = 2;
            // 
            // saveOrderbtn
            // 
            this.saveOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveOrderbtn.Location = new System.Drawing.Point(16, 232);
            this.saveOrderbtn.Name = "saveOrderbtn";
            this.saveOrderbtn.Size = new System.Drawing.Size(176, 42);
            this.saveOrderbtn.TabIndex = 1;
            this.saveOrderbtn.Text = "حفظ مبيعة";
            this.saveOrderbtn.UseVisualStyleBackColor = true;
            this.saveOrderbtn.Click += new System.EventHandler(this.saveOrderbtn_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(18, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "حذف السطر المحدد";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(18, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // newOrderbtn
            // 
            this.newOrderbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newOrderbtn.Location = new System.Drawing.Point(18, 183);
            this.newOrderbtn.Name = "newOrderbtn";
            this.newOrderbtn.Size = new System.Drawing.Size(176, 42);
            this.newOrderbtn.TabIndex = 0;
            this.newOrderbtn.Text = "مبيعة جديده";
            this.newOrderbtn.UseVisualStyleBackColor = true;
            this.newOrderbtn.Click += new System.EventHandler(this.newOrderbtn_Click);
            // 
            // choisCoustomerbtn
            // 
            this.choisCoustomerbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choisCoustomerbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choisCoustomerbtn.Location = new System.Drawing.Point(228, 24);
            this.choisCoustomerbtn.Name = "choisCoustomerbtn";
            this.choisCoustomerbtn.Size = new System.Drawing.Size(56, 42);
            this.choisCoustomerbtn.TabIndex = 4;
            this.choisCoustomerbtn.Text = "...";
            this.choisCoustomerbtn.UseVisualStyleBackColor = true;
            this.choisCoustomerbtn.Click += new System.EventHandler(this.choisCoustomerbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 301);
            this.panel1.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.salesnametxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateOrdertxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OrderDiscreptiontxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.idOrdertxt);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1138, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(427, 281);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الفاتورة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "اسم البائع";
            // 
            // salesnametxt
            // 
            this.salesnametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.salesnametxt.Location = new System.Drawing.Point(7, 228);
            this.salesnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.salesnametxt.Name = "salesnametxt";
            this.salesnametxt.ReadOnly = true;
            this.salesnametxt.Size = new System.Drawing.Size(312, 41);
            this.salesnametxt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "تاريخ الاصدار";
            // 
            // dateOrdertxt
            // 
            this.dateOrdertxt.BackColor = System.Drawing.Color.MintCream;
            this.dateOrdertxt.BorderRadius = 0;
            this.dateOrdertxt.ForeColor = System.Drawing.Color.Black;
            this.dateOrdertxt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateOrdertxt.FormatCustom = null;
            this.dateOrdertxt.Location = new System.Drawing.Point(10, 180);
            this.dateOrdertxt.Margin = new System.Windows.Forms.Padding(7);
            this.dateOrdertxt.Name = "dateOrdertxt";
            this.dateOrdertxt.Size = new System.Drawing.Size(309, 36);
            this.dateOrdertxt.TabIndex = 1;
            this.dateOrdertxt.Value = new System.DateTime(2025, 12, 2, 21, 26, 5, 329);
            this.dateOrdertxt.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "وصف الفاتورة";
            // 
            // OrderDiscreptiontxt
            // 
            this.OrderDiscreptiontxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderDiscreptiontxt.Location = new System.Drawing.Point(7, 79);
            this.OrderDiscreptiontxt.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDiscreptiontxt.Multiline = true;
            this.OrderDiscreptiontxt.Name = "OrderDiscreptiontxt";
            this.OrderDiscreptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderDiscreptiontxt.Size = new System.Drawing.Size(312, 90);
            this.OrderDiscreptiontxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "رقم الفاتورة";
            // 
            // idOrdertxt
            // 
            this.idOrdertxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idOrdertxt.Location = new System.Drawing.Point(7, 30);
            this.idOrdertxt.Margin = new System.Windows.Forms.Padding(4);
            this.idOrdertxt.Name = "idOrdertxt";
            this.idOrdertxt.Size = new System.Drawing.Size(312, 41);
            this.idOrdertxt.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.choisCoustomerbtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customeridtxt);
            this.groupBox1.Controls.Add(this.Lnametxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Fnametxt);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.teltxt);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(607, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(510, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "المعرف";
            // 
            // customeridtxt
            // 
            this.customeridtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customeridtxt.Location = new System.Drawing.Point(286, 25);
            this.customeridtxt.Margin = new System.Windows.Forms.Padding(4);
            this.customeridtxt.Name = "customeridtxt";
            this.customeridtxt.ReadOnly = true;
            this.customeridtxt.Size = new System.Drawing.Size(173, 41);
            this.customeridtxt.TabIndex = 36;
            // 
            // Lnametxt
            // 
            this.Lnametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lnametxt.Location = new System.Drawing.Point(233, 124);
            this.Lnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Lnametxt.Name = "Lnametxt";
            this.Lnametxt.ReadOnly = true;
            this.Lnametxt.Size = new System.Drawing.Size(226, 41);
            this.Lnametxt.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(465, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "الاسم الشخصي";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Fnametxt
            // 
            this.Fnametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fnametxt.Location = new System.Drawing.Point(233, 74);
            this.Fnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Fnametxt.Name = "Fnametxt";
            this.Fnametxt.ReadOnly = true;
            this.Fnametxt.Size = new System.Drawing.Size(226, 41);
            this.Fnametxt.TabIndex = 1;
            this.Fnametxt.TextChanged += new System.EventHandler(this.Fnametxt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(476, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "الاسم العائلي";
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emailtxt.Location = new System.Drawing.Point(233, 232);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.ReadOnly = true;
            this.emailtxt.Size = new System.Drawing.Size(226, 41);
            this.emailtxt.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(494, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "رقم الهاتف";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(457, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "البريد الالكتروني";
            // 
            // teltxt
            // 
            this.teltxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.teltxt.Location = new System.Drawing.Point(233, 175);
            this.teltxt.Margin = new System.Windows.Forms.Padding(4);
            this.teltxt.Name = "teltxt";
            this.teltxt.ReadOnly = true;
            this.teltxt.Size = new System.Drawing.Size(226, 41);
            this.teltxt.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.choisproductbtn);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.ptotalaftertxt);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.pdicounttxt);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.ptotalpricetxt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.pquantitytxt);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.pprictxt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.pnametxt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.ptxtid);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.finalyTotaltxt);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(1584, 612);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات المنتجات";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // choisproductbtn
            // 
            this.choisproductbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choisproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.choisproductbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choisproductbtn.Location = new System.Drawing.Point(1523, 63);
            this.choisproductbtn.Name = "choisproductbtn";
            this.choisproductbtn.Size = new System.Drawing.Size(53, 30);
            this.choisproductbtn.TabIndex = 52;
            this.choisproductbtn.Text = "...";
            this.choisproductbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.choisproductbtn.UseVisualStyleBackColor = true;
            this.choisproductbtn.Click += new System.EventHandler(this.choisproductbtn_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1523, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(53, 35);
            this.label18.TabIndex = 51;
            this.label18.Text = "اختيار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptotalaftertxt
            // 
            this.ptotalaftertxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptotalaftertxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotalaftertxt.Location = new System.Drawing.Point(524, 62);
            this.ptotalaftertxt.Margin = new System.Windows.Forms.Padding(4);
            this.ptotalaftertxt.Name = "ptotalaftertxt";
            this.ptotalaftertxt.ReadOnly = true;
            this.ptotalaftertxt.Size = new System.Drawing.Size(136, 41);
            this.ptotalaftertxt.TabIndex = 49;
            this.ptotalaftertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(524, 27);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(136, 35);
            this.label17.TabIndex = 50;
            this.label17.Text = "السعر بعد الخصم";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdicounttxt
            // 
            this.pdicounttxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pdicounttxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdicounttxt.Location = new System.Drawing.Point(663, 62);
            this.pdicounttxt.Margin = new System.Windows.Forms.Padding(4);
            this.pdicounttxt.MaxLength = 2324;
            this.pdicounttxt.Name = "pdicounttxt";
            this.pdicounttxt.Size = new System.Drawing.Size(151, 41);
            this.pdicounttxt.TabIndex = 47;
            this.pdicounttxt.Text = "0";
            this.pdicounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pdicounttxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pdicounttxt_KeyDown);
            this.pdicounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pdicounttxt_KeyPress);
            this.pdicounttxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pdicounttxt_KeyUp);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(663, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(151, 35);
            this.label16.TabIndex = 48;
            this.label16.Text = "الخصم(%)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptotalpricetxt
            // 
            this.ptotalpricetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptotalpricetxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptotalpricetxt.Location = new System.Drawing.Point(819, 62);
            this.ptotalpricetxt.Margin = new System.Windows.Forms.Padding(4);
            this.ptotalpricetxt.Name = "ptotalpricetxt";
            this.ptotalpricetxt.ReadOnly = true;
            this.ptotalpricetxt.Size = new System.Drawing.Size(129, 41);
            this.ptotalpricetxt.TabIndex = 45;
            this.ptotalpricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(819, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(129, 35);
            this.label15.TabIndex = 46;
            this.label15.Text = "السعر الكلي";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pquantitytxt
            // 
            this.pquantitytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pquantitytxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pquantitytxt.Location = new System.Drawing.Point(950, 62);
            this.pquantitytxt.Margin = new System.Windows.Forms.Padding(4);
            this.pquantitytxt.MaxLength = 2343;
            this.pquantitytxt.Name = "pquantitytxt";
            this.pquantitytxt.Size = new System.Drawing.Size(138, 41);
            this.pquantitytxt.TabIndex = 43;
            this.pquantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pquantitytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pquantitytxt_KeyPress);
            this.pquantitytxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pquantitytxt_KeyUp);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(950, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(138, 35);
            this.label14.TabIndex = 44;
            this.label14.Text = "الكمية";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pprictxt
            // 
            this.pprictxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pprictxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprictxt.Location = new System.Drawing.Point(1090, 62);
            this.pprictxt.Margin = new System.Windows.Forms.Padding(4);
            this.pprictxt.Name = "pprictxt";
            this.pprictxt.ReadOnly = true;
            this.pprictxt.Size = new System.Drawing.Size(144, 41);
            this.pprictxt.TabIndex = 41;
            this.pprictxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1090, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(144, 35);
            this.label13.TabIndex = 42;
            this.label13.Text = "السعر";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnametxt
            // 
            this.pnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnametxt.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnametxt.Location = new System.Drawing.Point(1234, 62);
            this.pnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.ReadOnly = true;
            this.pnametxt.Size = new System.Drawing.Size(151, 41);
            this.pnametxt.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1234, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(151, 35);
            this.label12.TabIndex = 40;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptxtid
            // 
            this.ptxtid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptxtid.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptxtid.Location = new System.Drawing.Point(1386, 62);
            this.ptxtid.Margin = new System.Windows.Forms.Padding(4);
            this.ptxtid.Name = "ptxtid";
            this.ptxtid.ReadOnly = true;
            this.ptxtid.Size = new System.Drawing.Size(135, 41);
            this.ptxtid.TabIndex = 38;
            this.ptxtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1386, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(135, 35);
            this.label11.TabIndex = 38;
            this.label11.Text = "معرف المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, 567);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "المجموع";
            // 
            // finalyTotaltxt
            // 
            this.finalyTotaltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finalyTotaltxt.Location = new System.Drawing.Point(32, 556);
            this.finalyTotaltxt.Margin = new System.Windows.Forms.Padding(4);
            this.finalyTotaltxt.Name = "finalyTotaltxt";
            this.finalyTotaltxt.ReadOnly = true;
            this.finalyTotaltxt.Size = new System.Drawing.Size(206, 41);
            this.finalyTotaltxt.TabIndex = 36;
            this.finalyTotaltxt.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(7, 105);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1560, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOrder";
            this.Size = new System.Drawing.Size(1792, 913);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Lnametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Fnametxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salesnametxt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateOrdertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderDiscreptiontxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idOrdertxt;
        private System.Windows.Forms.Button saveOrderbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button newOrderbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox finalyTotaltxt;
        private System.Windows.Forms.Button choisCoustomerbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customeridtxt;
        private System.Windows.Forms.TextBox ptxtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ptotalaftertxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox pdicounttxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ptotalpricetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox pquantitytxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pprictxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button choisproductbtn;

    }
}
