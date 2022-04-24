namespace calendrier
{
    partial class done
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(done));
            this.btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.ActiveBorderThickness = 1;
            this.btn.ActiveCornerRadius = 20;
            this.btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn.BackColor = System.Drawing.SystemColors.Control;
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.ButtonText = "Modify datagridview";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.Snow;
            this.btn.IdleBorderThickness = 1;
            this.btn.IdleCornerRadius = 20;
            this.btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(159)))), ((int)(((byte)(227)))));
            this.btn.IdleForecolor = System.Drawing.Color.White;
            this.btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.btn.Location = new System.Drawing.Point(478, 361);
            this.btn.Margin = new System.Windows.Forms.Padding(5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(203, 37);
            this.btn.TabIndex = 161;
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 295);
            this.dataGridView1.TabIndex = 162;
            // 
            // done
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn);
            this.Name = "done";
            this.Text = "done";
            this.Load += new System.EventHandler(this.done_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}