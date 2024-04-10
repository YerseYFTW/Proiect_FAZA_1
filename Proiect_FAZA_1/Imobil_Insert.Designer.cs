namespace Proiect_FAZA_1
{
    partial class Imobil_Insert
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.btnSaveIMBINS = new System.Windows.Forms.Button();
            this.btnCancelIMBINS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Prenume proprietar";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(221, 79);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(176, 20);
            this.tb1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adaugare nou imobil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nr. camere";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(221, 151);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(176, 52);
            this.tb2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresa completa";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(221, 209);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(109, 20);
            this.tb3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pretul dorit ( in euro)";
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(221, 116);
            this.nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(51, 20);
            this.nud1.TabIndex = 9;
            this.nud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveIMBINS
            // 
            this.btnSaveIMBINS.Location = new System.Drawing.Point(374, 288);
            this.btnSaveIMBINS.Name = "btnSaveIMBINS";
            this.btnSaveIMBINS.Size = new System.Drawing.Size(102, 43);
            this.btnSaveIMBINS.TabIndex = 10;
            this.btnSaveIMBINS.Text = "ADAUGA";
            this.btnSaveIMBINS.UseVisualStyleBackColor = true;
            this.btnSaveIMBINS.Click += new System.EventHandler(this.btnSaveIMBINS_Click);
            // 
            // btnCancelIMBINS
            // 
            this.btnCancelIMBINS.Location = new System.Drawing.Point(103, 288);
            this.btnCancelIMBINS.Name = "btnCancelIMBINS";
            this.btnCancelIMBINS.Size = new System.Drawing.Size(99, 43);
            this.btnCancelIMBINS.TabIndex = 11;
            this.btnCancelIMBINS.Text = "ANULEAZA";
            this.btnCancelIMBINS.UseVisualStyleBackColor = true;
            this.btnCancelIMBINS.Click += new System.EventHandler(this.btnCancelIMBINS_Click);
            // 
            // Imobil_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.btnCancelIMBINS);
            this.Controls.Add(this.btnSaveIMBINS);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Name = "Imobil_Insert";
            this.Text = "Imobil_Insert";
            this.Load += new System.EventHandler(this.Imobil_Insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Button btnSaveIMBINS;
        private System.Windows.Forms.Button btnCancelIMBINS;
    }
}