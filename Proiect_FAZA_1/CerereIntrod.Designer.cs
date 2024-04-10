namespace Proiect_FAZA_1
{
    partial class CerereIntrod
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
            this.btnCancelIMBINS = new System.Windows.Forms.Button();
            this.btnSaveIMBINS = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelIMBINS
            // 
            this.btnCancelIMBINS.Location = new System.Drawing.Point(84, 235);
            this.btnCancelIMBINS.Name = "btnCancelIMBINS";
            this.btnCancelIMBINS.Size = new System.Drawing.Size(99, 43);
            this.btnCancelIMBINS.TabIndex = 31;
            this.btnCancelIMBINS.Text = "ANULEAZA";
            this.btnCancelIMBINS.UseVisualStyleBackColor = true;
            this.btnCancelIMBINS.Click += new System.EventHandler(this.btnCancelIMBINS_Click);
            // 
            // btnSaveIMBINS
            // 
            this.btnSaveIMBINS.Location = new System.Drawing.Point(355, 235);
            this.btnSaveIMBINS.Name = "btnSaveIMBINS";
            this.btnSaveIMBINS.Size = new System.Drawing.Size(102, 43);
            this.btnSaveIMBINS.TabIndex = 30;
            this.btnSaveIMBINS.Text = "ADAUGA";
            this.btnSaveIMBINS.UseVisualStyleBackColor = true;
            this.btnSaveIMBINS.Click += new System.EventHandler(this.btnSaveIMBINS_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(196, 132);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(176, 68);
            this.tb3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descriere";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(196, 96);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(176, 21);
            this.tb2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Subiectul cererii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adaugare cerere";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(196, 60);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(176, 20);
            this.tb1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nume Prenume petant\r\n\r\n";
            // 
            // CerereIntrod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.btnCancelIMBINS);
            this.Controls.Add(this.btnSaveIMBINS);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label1);
            this.Name = "CerereIntrod";
            this.Text = "CerereIntrod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelIMBINS;
        private System.Windows.Forms.Button btnSaveIMBINS;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label1;
    }
}