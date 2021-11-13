
namespace Sınav_1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKahve = new System.Windows.Forms.ComboBox();
            this.cmbSoguk = new System.Windows.Forms.ComboBox();
            this.cmbSicak = new System.Windows.Forms.ComboBox();
            this.nudKahve = new System.Windows.Forms.NumericUpDown();
            this.nudSoguk = new System.Windows.Forms.NumericUpDown();
            this.nudSicak = new System.Windows.Forms.NumericUpDown();
            this.cb1x = new System.Windows.Forms.CheckBox();
            this.cb2x = new System.Windows.Forms.CheckBox();
            this.rbYagsiz = new System.Windows.Forms.RadioButton();
            this.rbSoya = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbVenti = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbTall = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKahve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoguk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSicak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(202, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilge Kahve Evi Sipariş Ekranı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sınav_1.Properties.Resources.KahveResim;
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müsşteri Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.nudSicak);
            this.groupBox2.Controls.Add(this.nudSoguk);
            this.groupBox2.Controls.Add(this.nudKahve);
            this.groupBox2.Controls.Add(this.cmbSicak);
            this.groupBox2.Controls.Add(this.cmbSoguk);
            this.groupBox2.Controls.Add(this.cmbKahve);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rbSoya);
            this.groupBox3.Controls.Add(this.rbYagsiz);
            this.groupBox3.Controls.Add(this.cb2x);
            this.groupBox3.Controls.Add(this.cb1x);
            this.groupBox3.Location = new System.Drawing.Point(13, 545);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstralar";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 713);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(487, 43);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 16;
            this.lstSiparis.Location = new System.Drawing.Point(506, 109);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(487, 548);
            this.lstSiparis.TabIndex = 5;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(525, 663);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(367, 31);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Toplam Sipariş Tutarı: 0 TL";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(506, 713);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(487, 43);
            this.btnSiparisVer.TabIndex = 7;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbTall);
            this.groupBox4.Controls.Add(this.rbGrande);
            this.groupBox4.Controls.Add(this.rbVenti);
            this.groupBox4.Location = new System.Drawing.Point(13, 629);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 78);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İçecek Boyutu";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(76, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(101, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(380, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(101, 50);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(380, 22);
            this.txtTel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(101, 78);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(380, 124);
            this.txtAdres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sıcak İçecekler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soğuk İçecekler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kaveler";
            // 
            // cmbKahve
            // 
            this.cmbKahve.FormattingEnabled = true;
            this.cmbKahve.Location = new System.Drawing.Point(168, 54);
            this.cmbKahve.Name = "cmbKahve";
            this.cmbKahve.Size = new System.Drawing.Size(244, 24);
            this.cmbKahve.TabIndex = 8;
            // 
            // cmbSoguk
            // 
            this.cmbSoguk.FormattingEnabled = true;
            this.cmbSoguk.Location = new System.Drawing.Point(168, 96);
            this.cmbSoguk.Name = "cmbSoguk";
            this.cmbSoguk.Size = new System.Drawing.Size(244, 24);
            this.cmbSoguk.TabIndex = 9;
            // 
            // cmbSicak
            // 
            this.cmbSicak.FormattingEnabled = true;
            this.cmbSicak.Location = new System.Drawing.Point(168, 139);
            this.cmbSicak.Name = "cmbSicak";
            this.cmbSicak.Size = new System.Drawing.Size(244, 24);
            this.cmbSicak.TabIndex = 10;
            // 
            // nudKahve
            // 
            this.nudKahve.Location = new System.Drawing.Point(418, 54);
            this.nudKahve.Name = "nudKahve";
            this.nudKahve.Size = new System.Drawing.Size(47, 22);
            this.nudKahve.TabIndex = 11;
            // 
            // nudSoguk
            // 
            this.nudSoguk.Location = new System.Drawing.Point(418, 96);
            this.nudSoguk.Name = "nudSoguk";
            this.nudSoguk.Size = new System.Drawing.Size(47, 22);
            this.nudSoguk.TabIndex = 12;
            // 
            // nudSicak
            // 
            this.nudSicak.Location = new System.Drawing.Point(418, 139);
            this.nudSicak.Name = "nudSicak";
            this.nudSicak.Size = new System.Drawing.Size(47, 22);
            this.nudSicak.TabIndex = 13;
            // 
            // cb1x
            // 
            this.cb1x.AutoSize = true;
            this.cb1x.Location = new System.Drawing.Point(125, 21);
            this.cb1x.Name = "cb1x";
            this.cb1x.Size = new System.Drawing.Size(42, 20);
            this.cb1x.TabIndex = 0;
            this.cb1x.Text = "1x";
            this.cb1x.UseVisualStyleBackColor = true;
            // 
            // cb2x
            // 
            this.cb2x.AutoSize = true;
            this.cb2x.Location = new System.Drawing.Point(233, 21);
            this.cb2x.Name = "cb2x";
            this.cb2x.Size = new System.Drawing.Size(42, 20);
            this.cb2x.TabIndex = 1;
            this.cb2x.Text = "2x";
            this.cb2x.UseVisualStyleBackColor = true;
            // 
            // rbYagsiz
            // 
            this.rbYagsiz.AutoSize = true;
            this.rbYagsiz.Location = new System.Drawing.Point(125, 48);
            this.rbYagsiz.Name = "rbYagsiz";
            this.rbYagsiz.Size = new System.Drawing.Size(73, 20);
            this.rbYagsiz.TabIndex = 2;
            this.rbYagsiz.TabStop = true;
            this.rbYagsiz.Text = "Yağsız";
            this.rbYagsiz.UseVisualStyleBackColor = true;
            // 
            // rbSoya
            // 
            this.rbSoya.AutoSize = true;
            this.rbSoya.Location = new System.Drawing.Point(233, 48);
            this.rbSoya.Name = "rbSoya";
            this.rbSoya.Size = new System.Drawing.Size(62, 20);
            this.rbSoya.TabIndex = 3;
            this.rbSoya.TabStop = true;
            this.rbSoya.Text = "Soya";
            this.rbSoya.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Shot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Süt";
            // 
            // rbVenti
            // 
            this.rbVenti.AutoSize = true;
            this.rbVenti.Location = new System.Drawing.Point(125, 34);
            this.rbVenti.Name = "rbVenti";
            this.rbVenti.Size = new System.Drawing.Size(61, 20);
            this.rbVenti.TabIndex = 0;
            this.rbVenti.TabStop = true;
            this.rbVenti.Text = "Venti";
            this.rbVenti.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(244, 34);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(77, 20);
            this.rbGrande.TabIndex = 1;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbTall
            // 
            this.rbTall.AutoSize = true;
            this.rbTall.Location = new System.Drawing.Point(363, 34);
            this.rbTall.Name = "rbTall";
            this.rbTall.Size = new System.Drawing.Size(53, 20);
            this.rbTall.TabIndex = 2;
            this.rbTall.TabStop = true;
            this.rbTall.Text = "Tall";
            this.rbTall.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sınav_1.Properties.Resources.KahveResim;
            this.pictureBox2.Location = new System.Drawing.Point(11, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sınav_1.Properties.Resources.Soğukİçcecek;
            this.pictureBox3.Location = new System.Drawing.Point(11, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sınav_1.Properties.Resources.sıcakİçcecek;
            this.pictureBox4.Location = new System.Drawing.Point(11, 138);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 768);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKahve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoguk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSicak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudSicak;
        private System.Windows.Forms.NumericUpDown nudSoguk;
        private System.Windows.Forms.NumericUpDown nudKahve;
        private System.Windows.Forms.ComboBox cmbSicak;
        private System.Windows.Forms.ComboBox cmbSoguk;
        private System.Windows.Forms.ComboBox cmbKahve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbSoya;
        private System.Windows.Forms.RadioButton rbYagsiz;
        private System.Windows.Forms.CheckBox cb2x;
        private System.Windows.Forms.CheckBox cb1x;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTall;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbVenti;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

