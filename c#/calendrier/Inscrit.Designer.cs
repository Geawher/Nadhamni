namespace calendrier
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Last_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Date_naiss = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Mail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Firstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Arial Narrow", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.HintForeColor = System.Drawing.Color.White;
            this.Username.HintText = "Username";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Username.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(204, 210);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(195, 37);
            this.Username.TabIndex = 16;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Last_name
            // 
            this.Last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Last_name.Font = new System.Drawing.Font("Arial Narrow", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Last_name.HintForeColor = System.Drawing.Color.White;
            this.Last_name.HintText = "Last Name";
            this.Last_name.isPassword = false;
            this.Last_name.LineFocusedColor = System.Drawing.Color.RosyBrown;
            this.Last_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Last_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Last_name.LineThickness = 3;
            this.Last_name.Location = new System.Drawing.Point(204, 152);
            this.Last_name.Margin = new System.Windows.Forms.Padding(4);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(195, 37);
            this.Last_name.TabIndex = 15;
            this.Last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Last_name.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // Date_naiss
            // 
            this.Date_naiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Date_naiss.BorderRadius = 0;
            this.Date_naiss.ForeColor = System.Drawing.Color.White;
            this.Date_naiss.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_naiss.FormatCustom = null;
            this.Date_naiss.Location = new System.Drawing.Point(198, 388);
            this.Date_naiss.Name = "Date_naiss";
            this.Date_naiss.Size = new System.Drawing.Size(202, 36);
            this.Date_naiss.TabIndex = 24;
            this.Date_naiss.Value = new System.DateTime(2020, 3, 8, 16, 40, 2, 524);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Arial Narrow", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.HintForeColor = System.Drawing.Color.White;
            this.Password.HintText = "Password";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Password.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(204, 273);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(195, 37);
            this.Password.TabIndex = 25;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // Mail
            // 
            this.Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mail.Font = new System.Drawing.Font("Arial Narrow", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.Color.White;
            this.Mail.HintForeColor = System.Drawing.Color.White;
            this.Mail.HintText = "Mail ";
            this.Mail.isPassword = false;
            this.Mail.LineFocusedColor = System.Drawing.Color.Blue;
            this.Mail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Mail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Mail.LineThickness = 3;
            this.Mail.Location = new System.Drawing.Point(205, 330);
            this.Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(195, 37);
            this.Mail.TabIndex = 26;
            this.Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(176, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(176, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(176, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(176, 439);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(176, 338);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 34;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(257, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "SIGN UP";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.ForeColor = System.Drawing.Color.White;
            this.r1.Location = new System.Drawing.Point(243, 456);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(47, 17);
            this.r1.TabIndex = 36;
            this.r1.TabStop = true;
            this.r1.Text = "male";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Century", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.White;
            this.r2.Location = new System.Drawing.Point(370, 456);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(56, 19);
            this.r2.TabIndex = 37;
            this.r2.TabStop = true;
            this.r2.Text = "female";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "NEXT";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Snow;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(411, 483);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(103, 41);
            this.bunifuThinButton21.TabIndex = 38;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Firstname
            // 
            this.Firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Firstname.Font = new System.Drawing.Font("Arial Narrow", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.ForeColor = System.Drawing.Color.White;
            this.Firstname.HintForeColor = System.Drawing.Color.White;
            this.Firstname.HintText = "First name";
            this.Firstname.isPassword = false;
            this.Firstname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Firstname.LineIdleColor = System.Drawing.Color.Gray;
            this.Firstname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.Firstname.LineThickness = 3;
            this.Firstname.Location = new System.Drawing.Point(205, 83);
            this.Firstname.Margin = new System.Windows.Forms.Padding(4);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(195, 37);
            this.Firstname.TabIndex = 39;
            this.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(721, 535);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Date_naiss);
            this.Controls.Add(this.Last_name);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Last_name;
        private Bunifu.Framework.UI.BunifuDatepicker Date_naiss;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Mail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Firstname;
    }
}