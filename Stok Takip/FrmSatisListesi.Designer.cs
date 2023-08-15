namespace Stok_Takip
{
	partial class FrmSatisListesi
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
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSil = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnAra = new System.Windows.Forms.Button();
			this.cbTarih = new System.Windows.Forms.CheckBox();
			this.dpBitis = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dpBaslama = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMusteriAdi = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbSKücük = new System.Windows.Forms.RadioButton();
			this.rbSEsit = new System.Windows.Forms.RadioButton();
			this.rbSBüyük = new System.Windows.Forms.RadioButton();
			this.gbFiyat = new System.Windows.Forms.GroupBox();
			this.rdbKücük = new System.Windows.Forms.RadioButton();
			this.rdbEsit = new System.Windows.Forms.RadioButton();
			this.RdbBüyük = new System.Windows.Forms.RadioButton();
			this.txtSatis = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbKategori = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbFiyat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(408, 33);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(126, 55);
			this.btnGuncelle.TabIndex = 9;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKapat.Location = new System.Drawing.Point(741, 33);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(126, 55);
			this.btnKapat.TabIndex = 7;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(246, 33);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(126, 55);
			this.btnEkle.TabIndex = 10;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnEkle);
			this.panel2.Controls.Add(this.btnGuncelle);
			this.panel2.Controls.Add(this.btnSil);
			this.panel2.Controls.Add(this.btnKapat);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 393);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1058, 106);
			this.panel2.TabIndex = 7;
			// 
			// btnSil
			// 
			this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Location = new System.Drawing.Point(576, 33);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(126, 55);
			this.btnSil.TabIndex = 8;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnTemizle);
			this.panel1.Controls.Add(this.btnAra);
			this.panel1.Controls.Add(this.cbTarih);
			this.panel1.Controls.Add(this.dpBitis);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dpBaslama);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtMusteriAdi);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.gbFiyat);
			this.panel1.Controls.Add(this.txtSatis);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtFiyat);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cmbKategori);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUrunAd);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1058, 177);
			this.panel1.TabIndex = 6;
			// 
			// btnTemizle
			// 
			this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.Location = new System.Drawing.Point(911, 89);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(126, 66);
			this.btnTemizle.TabIndex = 66;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = true;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// btnAra
			// 
			this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAra.Location = new System.Drawing.Point(911, 12);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(126, 67);
			this.btnAra.TabIndex = 65;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// cbTarih
			// 
			this.cbTarih.AutoSize = true;
			this.cbTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbTarih.Location = new System.Drawing.Point(810, 129);
			this.cbTarih.Name = "cbTarih";
			this.cbTarih.Size = new System.Drawing.Size(84, 29);
			this.cbTarih.TabIndex = 64;
			this.cbTarih.Text = "Tarih";
			this.cbTarih.UseVisualStyleBackColor = true;
			// 
			// dpBitis
			// 
			this.dpBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dpBitis.Location = new System.Drawing.Point(643, 133);
			this.dpBitis.Name = "dpBitis";
			this.dpBitis.Size = new System.Drawing.Size(161, 22);
			this.dpBitis.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(603, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 25);
			this.label7.TabIndex = 62;
			this.label7.Text = "ile";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(311, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 25);
			this.label6.TabIndex = 61;
			this.label6.Text = "Satış Tarihi";
			// 
			// dpBaslama
			// 
			this.dpBaslama.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dpBaslama.Location = new System.Drawing.Point(439, 133);
			this.dpBaslama.Name = "dpBaslama";
			this.dpBaslama.Size = new System.Drawing.Size(166, 22);
			this.dpBaslama.TabIndex = 60;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(12, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 25);
			this.label5.TabIndex = 59;
			this.label5.Text = "Müşteri Ad";
			// 
			// txtMusteriAdi
			// 
			this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMusteriAdi.Location = new System.Drawing.Point(134, 21);
			this.txtMusteriAdi.Name = "txtMusteriAdi";
			this.txtMusteriAdi.Size = new System.Drawing.Size(171, 30);
			this.txtMusteriAdi.TabIndex = 58;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbSKücük);
			this.groupBox1.Controls.Add(this.rbSEsit);
			this.groupBox1.Controls.Add(this.rbSBüyük);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(618, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(249, 47);
			this.groupBox1.TabIndex = 57;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Satış";
			// 
			// rbSKücük
			// 
			this.rbSKücük.AutoSize = true;
			this.rbSKücük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rbSKücük.Location = new System.Drawing.Point(156, 23);
			this.rbSKücük.Name = "rbSKücük";
			this.rbSKücük.Size = new System.Drawing.Size(81, 24);
			this.rbSKücük.TabIndex = 3;
			this.rbSKücük.TabStop = true;
			this.rbSKücük.Text = "Küçük";
			this.rbSKücük.UseVisualStyleBackColor = true;
			// 
			// rbSEsit
			// 
			this.rbSEsit.AutoSize = true;
			this.rbSEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rbSEsit.Location = new System.Drawing.Point(87, 22);
			this.rbSEsit.Name = "rbSEsit";
			this.rbSEsit.Size = new System.Drawing.Size(63, 24);
			this.rbSEsit.TabIndex = 2;
			this.rbSEsit.TabStop = true;
			this.rbSEsit.Text = "Eşit";
			this.rbSEsit.UseVisualStyleBackColor = true;
			// 
			// rbSBüyük
			// 
			this.rbSBüyük.AutoSize = true;
			this.rbSBüyük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbSBüyük.Location = new System.Drawing.Point(0, 24);
			this.rbSBüyük.Name = "rbSBüyük";
			this.rbSBüyük.Size = new System.Drawing.Size(81, 24);
			this.rbSBüyük.TabIndex = 1;
			this.rbSBüyük.TabStop = true;
			this.rbSBüyük.Text = "Büyük";
			this.rbSBüyük.UseVisualStyleBackColor = true;
			// 
			// gbFiyat
			// 
			this.gbFiyat.Controls.Add(this.rdbKücük);
			this.gbFiyat.Controls.Add(this.rdbEsit);
			this.gbFiyat.Controls.Add(this.RdbBüyük);
			this.gbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbFiyat.Location = new System.Drawing.Point(618, 1);
			this.gbFiyat.Name = "gbFiyat";
			this.gbFiyat.Size = new System.Drawing.Size(249, 50);
			this.gbFiyat.TabIndex = 56;
			this.gbFiyat.TabStop = false;
			this.gbFiyat.Text = "Fiyat";
			// 
			// rdbKücük
			// 
			this.rdbKücük.AutoSize = true;
			this.rdbKücük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rdbKücük.Location = new System.Drawing.Point(162, 24);
			this.rdbKücük.Name = "rdbKücük";
			this.rdbKücük.Size = new System.Drawing.Size(81, 24);
			this.rdbKücük.TabIndex = 3;
			this.rdbKücük.TabStop = true;
			this.rdbKücük.Text = "Küçük";
			this.rdbKücük.UseVisualStyleBackColor = true;
			// 
			// rdbEsit
			// 
			this.rdbEsit.AutoSize = true;
			this.rdbEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rdbEsit.Location = new System.Drawing.Point(93, 23);
			this.rdbEsit.Name = "rdbEsit";
			this.rdbEsit.Size = new System.Drawing.Size(63, 24);
			this.rdbEsit.TabIndex = 2;
			this.rdbEsit.TabStop = true;
			this.rdbEsit.Text = "Eşit";
			this.rdbEsit.UseVisualStyleBackColor = true;
			// 
			// RdbBüyük
			// 
			this.RdbBüyük.AutoSize = true;
			this.RdbBüyük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.RdbBüyük.Location = new System.Drawing.Point(6, 21);
			this.RdbBüyük.Name = "RdbBüyük";
			this.RdbBüyük.Size = new System.Drawing.Size(81, 24);
			this.RdbBüyük.TabIndex = 1;
			this.RdbBüyük.TabStop = true;
			this.RdbBüyük.Text = "Büyük";
			this.RdbBüyük.UseVisualStyleBackColor = true;
			// 
			// txtSatis
			// 
			this.txtSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSatis.Location = new System.Drawing.Point(439, 74);
			this.txtSatis.Name = "txtSatis";
			this.txtSatis.Size = new System.Drawing.Size(166, 30);
			this.txtSatis.TabIndex = 55;
			this.txtSatis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatis_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(311, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 25);
			this.label1.TabIndex = 54;
			this.label1.Text = "Satış Miktarı";
			// 
			// txtFiyat
			// 
			this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtFiyat.Location = new System.Drawing.Point(439, 22);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(166, 30);
			this.txtFiyat.TabIndex = 52;
			this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(311, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 25);
			this.label4.TabIndex = 53;
			this.label4.Text = "Ürün Fiyat";
			// 
			// cmbKategori
			// 
			this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbKategori.FormattingEnabled = true;
			this.cmbKategori.Location = new System.Drawing.Point(134, 122);
			this.cmbKategori.Name = "cmbKategori";
			this.cmbKategori.Size = new System.Drawing.Size(171, 33);
			this.cmbKategori.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 50;
			this.label2.Text = "Kategori";
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAd.Location = new System.Drawing.Point(134, 69);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.Size = new System.Drawing.Size(171, 30);
			this.txtUrunAd.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 25);
			this.label3.TabIndex = 49;
			this.label3.Text = "Ürün Adı";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1058, 216);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// FrmSatisListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 499);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmSatisListesi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Satış Listesi";
			this.Load += new System.EventHandler(this.FrmSatisListesi_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbFiyat.ResumeLayout(false);
			this.gbFiyat.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cbTarih;
		private System.Windows.Forms.DateTimePicker dpBitis;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dpBaslama;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMusteriAdi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbSKücük;
		private System.Windows.Forms.RadioButton rbSEsit;
		private System.Windows.Forms.RadioButton rbSBüyük;
		private System.Windows.Forms.GroupBox gbFiyat;
		private System.Windows.Forms.RadioButton rdbKücük;
		private System.Windows.Forms.RadioButton rdbEsit;
		private System.Windows.Forms.RadioButton RdbBüyük;
		private System.Windows.Forms.TextBox txtSatis;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbKategori;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}