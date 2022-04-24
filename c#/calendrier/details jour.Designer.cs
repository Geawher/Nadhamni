namespace calendrier
{
    partial class details_jour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(details_jour));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.affichage = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affichage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(713, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 607);
            this.panel2.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::calendrier1.Properties.Resources.dddd;
            this.panel6.Location = new System.Drawing.Point(84, 316);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 68);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::calendrier1.Properties.Resources._123;
            this.panel5.Location = new System.Drawing.Point(85, 425);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 75);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::calendrier1.Properties.Resources._12547;
            this.panel4.Location = new System.Drawing.Point(69, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 70);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::calendrier1.Properties.Resources._1250;
            this.panel3.Location = new System.Drawing.Point(35, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 166);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "If you cannot do great things,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(217, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = " do small things in a great way";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::calendrier1.Properties.Resources.toppng2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // affichage
            // 
            this.affichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.affichage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.date_debut,
            this.Temps,
            this.categorie,
            this.adr,
            this.recc});
            this.affichage.Location = new System.Drawing.Point(26, 100);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(643, 399);
            this.affichage.TabIndex = 6;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // date_debut
            // 
            this.date_debut.HeaderText = "Date";
            this.date_debut.Name = "date_debut";
            // 
            // Temps
            // 
            this.Temps.HeaderText = "Temps de l\'activité";
            this.Temps.Name = "Temps";
            this.Temps.ReadOnly = true;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Categorie";
            this.categorie.Name = "categorie";
            this.categorie.ReadOnly = true;
            // 
            // adr
            // 
            this.adr.HeaderText = "Adresse";
            this.adr.Name = "adr";
            this.adr.ReadOnly = true;
            // 
            // recc
            // 
            this.recc.HeaderText = "Reccurence";
            this.recc.Name = "recc";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printPreviewDialog1_Load);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // details_jour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.affichage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "details_jour";
            this.Text = "details_jour";
            this.Load += new System.EventHandler(this.details_jour_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.affichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView affichage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr;
        private System.Windows.Forms.DataGridViewTextBoxColumn recc;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
    }
}