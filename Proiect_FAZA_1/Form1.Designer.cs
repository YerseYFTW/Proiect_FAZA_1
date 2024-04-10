namespace Proiect_FAZA_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imobilToolStripMenuItem,
            this.ofertaToolStripMenuItem,
            this.cerereToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // imobilToolStripMenuItem
            // 
            this.imobilToolStripMenuItem.Name = "imobilToolStripMenuItem";
            this.imobilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.imobilToolStripMenuItem.Text = "Imobil";
            this.imobilToolStripMenuItem.Click += new System.EventHandler(this.imobilToolStripMenuItem_Click);
            // 
            // ofertaToolStripMenuItem
            // 
            this.ofertaToolStripMenuItem.Name = "ofertaToolStripMenuItem";
            this.ofertaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ofertaToolStripMenuItem.Text = "Oferta";
            this.ofertaToolStripMenuItem.Click += new System.EventHandler(this.ofertaToolStripMenuItem_Click);
            // 
            // cerereToolStripMenuItem
            // 
            this.cerereToolStripMenuItem.Name = "cerereToolStripMenuItem";
            this.cerereToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.cerereToolStripMenuItem.Text = "Cerere";
            this.cerereToolStripMenuItem.Click += new System.EventHandler(this.cerereToolStripMenuItem_Click);
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TIP,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader11});
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(12, 211);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(347, 138);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // TIP
            // 
            this.TIP.Text = "Stare operatie";
            this.TIP.Width = 96;
            // 
            // columnHeader12
            // 
            this.columnHeader12.DisplayIndex = 4;
            this.columnHeader12.Text = "Doritor";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "ID imobil";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader11
            // 
            this.columnHeader11.DisplayIndex = 3;
            this.columnHeader11.Text = "Pret";
            // 
            // tbMes
            // 
            this.tbMes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMes.Location = new System.Drawing.Point(0, 355);
            this.tbMes.Multiline = true;
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(800, 95);
            this.tbMes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imobile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(365, 211);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(423, 138);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nume Prenume";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID imobil";
            this.columnHeader4.Width = 59;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Motiv";
            this.columnHeader10.Width = 275;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 52);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(776, 116);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 26;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Proprietar";
            this.columnHeader6.Width = 91;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Camere";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adresa";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cereri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oferte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerereToolStripMenuItem;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader TIP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

