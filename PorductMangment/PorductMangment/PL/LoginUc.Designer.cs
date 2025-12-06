namespace PorductMangment.PL
{
    partial class LoginUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUc));
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.c5 = new System.Windows.Forms.Label();
            this.cr4 = new System.Windows.Forms.Label();
            this.titel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginbtn.AutoEllipsis = true;
            this.loginbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbtn.Location = new System.Drawing.Point(90, 326);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(143, 41);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "تسجيل الدخول";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(687, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(687, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "كلمة المرور";
            // 
            // exitbtn
            // 
            this.exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitbtn.AutoEllipsis = true;
            this.exitbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exitbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitbtn.Location = new System.Drawing.Point(265, 326);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(113, 41);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "الغاء";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.passtxt);
            this.panel1.Controls.Add(this.nametxt);
            this.panel1.Controls.Add(this.c5);
            this.panel1.Controls.Add(this.cr4);
            this.panel1.Controls.Add(this.titel);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Location = new System.Drawing.Point(459, 237);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(953, 418);
            this.panel1.TabIndex = 0;
            // 
            // passtxt
            // 
            this.passtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passtxt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(211, 220);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '#';
            this.passtxt.Size = new System.Drawing.Size(423, 46);
            this.passtxt.TabIndex = 23;
            // 
            // nametxt
            // 
            this.nametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nametxt.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(211, 130);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(423, 46);
            this.nametxt.TabIndex = 22;
            // 
            // c5
            // 
            this.c5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c5.AutoSize = true;
            this.c5.BackColor = System.Drawing.Color.SteelBlue;
            this.c5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.c5.Location = new System.Drawing.Point(753, 311);
            this.c5.Name = "c5";
            this.c5.Padding = new System.Windows.Forms.Padding(150);
            this.c5.Size = new System.Drawing.Size(324, 334);
            this.c5.TabIndex = 21;
            this.c5.Text = " ";
            // 
            // cr4
            // 
            this.cr4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cr4.AutoSize = true;
            this.cr4.BackColor = System.Drawing.Color.DarkGray;
            this.cr4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cr4.Location = new System.Drawing.Point(-156, -151);
            this.cr4.Name = "cr4";
            this.cr4.Padding = new System.Windows.Forms.Padding(150);
            this.cr4.Size = new System.Drawing.Size(324, 334);
            this.cr4.TabIndex = 20;
            this.cr4.Text = " ";
            // 
            // titel
            // 
            this.titel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titel.AutoSize = true;
            this.titel.BackColor = System.Drawing.Color.LightSlateGray;
            this.titel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titel.Location = new System.Drawing.Point(753, 22);
            this.titel.Name = "titel";
            this.titel.Padding = new System.Windows.Forms.Padding(10);
            this.titel.Size = new System.Drawing.Size(209, 54);
            this.titel.TabIndex = 18;
            this.titel.Text = "تسجيل الدخول";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 200;
            this.bunifuElipse1.TargetControl = this.cr4;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 200;
            this.bunifuElipse2.TargetControl = this.c5;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this.panel1;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.titel;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 2;
            this.bunifuElipse5.TargetControl = this;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 2;
            this.bunifuElipse6.TargetControl = this;
            // 
            // LoginUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "LoginUc";
            this.Size = new System.Drawing.Size(1870, 892);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label cr4;
        private System.Windows.Forms.Label c5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox passtxt;
       


    }
}
