namespace ürün_indirimi1_777
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblİndirimlifiyat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblİndirimlifiyat);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.rb25);
            this.groupBox1.Controls.Add(this.rb15);
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "indirimli fiyat";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb5.Location = new System.Drawing.Point(18, 135);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(96, 20);
            this.rb5.TabIndex = 1;
            this.rb5.TabStop = true;
            this.rb5.Text = "%5 indirim";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb10.Location = new System.Drawing.Point(18, 173);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(104, 20);
            this.rb10.TabIndex = 2;
            this.rb10.TabStop = true;
            this.rb10.Text = "%10 indirim";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb15.Location = new System.Drawing.Point(18, 210);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(104, 20);
            this.rb15.TabIndex = 3;
            this.rb15.TabStop = true;
            this.rb15.Text = "%15 indirim";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb25.Location = new System.Drawing.Point(18, 246);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(104, 20);
            this.rb25.TabIndex = 4;
            this.rb25.TabStop = true;
            this.rb25.Text = "%25 indirim";
            this.rb25.UseVisualStyleBackColor = true;
            this.rb25.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(18, 305);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(358, 62);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click_1);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(80, 32);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(264, 20);
            this.txtTutar.TabIndex = 6;
            // 
            // lblİndirimlifiyat
            // 
            this.lblİndirimlifiyat.AutoSize = true;
            this.lblİndirimlifiyat.Location = new System.Drawing.Point(179, 76);
            this.lblİndirimlifiyat.Name = "lblİndirimlifiyat";
            this.lblİndirimlifiyat.Size = new System.Drawing.Size(151, 13);
            this.lblİndirimlifiyat.TabIndex = 7;
            this.lblİndirimlifiyat.Text = "________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblİndirimlifiyat;
        private System.Windows.Forms.TextBox txtTutar;
    }
}

