namespace OEE_Hesaplama {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxHatDurusu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlanlananZaman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUretim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCycle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRework = new System.Windows.Forms.TextBox();
            this.labelKullan = new System.Windows.Forms.Label();
            this.labelPerf = new System.Windows.Forms.Label();
            this.labelKalite = new System.Windows.Forms.Label();
            this.labelOEE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHatDurusu
            // 
            this.textBoxHatDurusu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHatDurusu.Location = new System.Drawing.Point(146, 27);
            this.textBoxHatDurusu.MaxLength = 32;
            this.textBoxHatDurusu.Name = "textBoxHatDurusu";
            this.textBoxHatDurusu.Size = new System.Drawing.Size(99, 29);
            this.textBoxHatDurusu.TabIndex = 0;
            this.textBoxHatDurusu.TextChanged += new System.EventHandler(this.textBoxHatDurusu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hat Duruşu:\r\n(Dakika)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPlanlananZaman);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUretim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCycle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxRework);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxHatDurusu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Değerler";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Planlanan Zaman: (Dakika)";
            // 
            // textBoxPlanlananZaman
            // 
            this.textBoxPlanlananZaman.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlanlananZaman.Location = new System.Drawing.Point(146, 198);
            this.textBoxPlanlananZaman.MaxLength = 8;
            this.textBoxPlanlananZaman.Name = "textBoxPlanlananZaman";
            this.textBoxPlanlananZaman.Size = new System.Drawing.Size(99, 29);
            this.textBoxPlanlananZaman.TabIndex = 8;
            this.textBoxPlanlananZaman.TextChanged += new System.EventHandler(this.textBoxPlanlananZaman_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Üretim Adeti:";
            // 
            // textBoxUretim
            // 
            this.textBoxUretim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUretim.Location = new System.Drawing.Point(146, 155);
            this.textBoxUretim.MaxLength = 32;
            this.textBoxUretim.Name = "textBoxUretim";
            this.textBoxUretim.Size = new System.Drawing.Size(99, 29);
            this.textBoxUretim.TabIndex = 6;
            this.textBoxUretim.TextChanged += new System.EventHandler(this.textBoxUretim_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Döngü Süresi: (Saniye)";
            // 
            // textBoxCycle
            // 
            this.textBoxCycle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCycle.Location = new System.Drawing.Point(146, 112);
            this.textBoxCycle.MaxLength = 8;
            this.textBoxCycle.Name = "textBoxCycle";
            this.textBoxCycle.Size = new System.Drawing.Size(99, 29);
            this.textBoxCycle.TabIndex = 4;
            this.textBoxCycle.TextChanged += new System.EventHandler(this.textBoxCycle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rework Adeti:";
            // 
            // textBoxRework
            // 
            this.textBoxRework.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRework.Location = new System.Drawing.Point(146, 69);
            this.textBoxRework.MaxLength = 32;
            this.textBoxRework.Name = "textBoxRework";
            this.textBoxRework.Size = new System.Drawing.Size(99, 29);
            this.textBoxRework.TabIndex = 2;
            this.textBoxRework.TextChanged += new System.EventHandler(this.textBoxRework_TextChanged);
            // 
            // labelKullan
            // 
            this.labelKullan.AutoSize = true;
            this.labelKullan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullan.Location = new System.Drawing.Point(440, 66);
            this.labelKullan.Name = "labelKullan";
            this.labelKullan.Size = new System.Drawing.Size(0, 25);
            this.labelKullan.TabIndex = 10;
            // 
            // labelPerf
            // 
            this.labelPerf.AutoSize = true;
            this.labelPerf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerf.Location = new System.Drawing.Point(413, 99);
            this.labelPerf.Name = "labelPerf";
            this.labelPerf.Size = new System.Drawing.Size(0, 25);
            this.labelPerf.TabIndex = 11;
            // 
            // labelKalite
            // 
            this.labelKalite.AutoSize = true;
            this.labelKalite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKalite.Location = new System.Drawing.Point(365, 135);
            this.labelKalite.Name = "labelKalite";
            this.labelKalite.Size = new System.Drawing.Size(0, 25);
            this.labelKalite.TabIndex = 12;
            // 
            // labelOEE
            // 
            this.labelOEE.AutoSize = true;
            this.labelOEE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOEE.Location = new System.Drawing.Point(350, 168);
            this.labelOEE.Name = "labelOEE";
            this.labelOEE.Size = new System.Drawing.Size(0, 25);
            this.labelOEE.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kullanılabilirlik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kalite:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "OEE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Performans:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(534, 265);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelOEE);
            this.Controls.Add(this.labelKalite);
            this.Controls.Add(this.labelKullan);
            this.Controls.Add(this.labelPerf);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OEE Hesaplama Programı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHatDurusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlanlananZaman;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUretim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRework;
        private System.Windows.Forms.Label labelKullan;
        private System.Windows.Forms.Label labelPerf;
        private System.Windows.Forms.Label labelKalite;
        private System.Windows.Forms.Label labelOEE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}

