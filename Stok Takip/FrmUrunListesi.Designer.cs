namespace Stok_Takip
{
	partial class FrmUrunListesi
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbStokKücük = new System.Windows.Forms.RadioButton();
			this.rbStokEsit = new System.Windows.Forms.RadioButton();
			this.rbStokBüyük = new System.Windows.Forms.RadioButton();
			this.gbFiyat = new System.Windows.Forms.GroupBox();
			this.rdbKücük = new System.Windows.Forms.RadioButton();
			this.rdbEsit = new System.Windows.Forms.RadioButton();
			this.RdbBüyük = new System.Windows.Forms.RadioButton();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbKategori = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnAra = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbFiyat.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.gbFiyat);
			this.panel1.Controls.Add(this.txtStok);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtFiyat);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.cmbKategori);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUrunAd);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnTemizle);
			this.panel1.Controls.Add(this.btnAra);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1053, 196);
			this.panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbStokKücük);
			this.groupBox1.Controls.Add(this.rbStokEsit);
			this.groupBox1.Controls.Add(this.rbStokBüyük);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(620, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(243, 63);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stok";
			// 
			// rbStokKücük
			// 
			this.rbStokKücük.AutoSize = true;
			this.rbStokKücük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rbStokKücük.Location = new System.Drawing.Point(156, 23);
			this.rbStokKücük.Name = "rbStokKücük";
			this.rbStokKücük.Size = new System.Drawing.Size(81, 24);
			this.rbStokKücük.TabIndex = 3;
			this.rbStokKücük.TabStop = true;
			this.rbStokKücük.Text = "Küçük";
			this.rbStokKücük.UseVisualStyleBackColor = true;
			// 
			// rbStokEsit
			// 
			this.rbStokEsit.AutoSize = true;
			this.rbStokEsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
			this.rbStokEsit.Location = new System.Drawing.Point(87, 22);
			this.rbStokEsit.Name = "rbStokEsit";
			this.rbStokEsit.Size = new System.Drawing.Size(63, 24);
			this.rbStokEsit.TabIndex = 2;
			this.rbStokEsit.TabStop = true;
			this.rbStokEsit.Text = "Eşit";
			this.rbStokEsit.UseVisualStyleBackColor = true;
			// 
			// rbStokBüyük
			// 
			this.rbStokBüyük.AutoSize = true;
			this.rbStokBüyük.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbStokBüyük.Location = new System.Drawing.Point(0, 24);
			this.rbStokBüyük.Name = "rbStokBüyük";
			this.rbStokBüyük.Size = new System.Drawing.Size(81, 24);
			this.rbStokBüyük.TabIndex = 1;
			this.rbStokBüyük.TabStop = true;
			this.rbStokBüyük.Text = "Büyük";
			this.rbStokBüyük.UseVisualStyleBackColor = true;
			// 
			// gbFiyat
			// 
			this.gbFiyat.Controls.Add(this.rdbKücük);
			this.gbFiyat.Controls.Add(this.rdbEsit);
			this.gbFiyat.Controls.Add(this.RdbBüyük);
			this.gbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gbFiyat.Location = new System.Drawing.Point(614, 36);
			this.gbFiyat.Name = "gbFiyat";
			this.gbFiyat.Size = new System.Drawing.Size(249, 50);
			this.gbFiyat.TabIndex = 30;
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
			// txtStok
			// 
			this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtStok.Location = new System.Drawing.Point(428, 113);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(180, 30);
			this.txtStok.TabIndex = 29;
			this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(311, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 25);
			this.label1.TabIndex = 28;
			this.label1.Text = "Ürün Stok";
			// 
			// txtFiyat
			// 
			this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtFiyat.Location = new System.Drawing.Point(428, 54);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(180, 30);
			this.txtFiyat.TabIndex = 26;
			this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(311, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 25);
			this.label4.TabIndex = 27;
			this.label4.Text = "Ürün Fiyat";
			// 
			// cmbKategori
			// 
			this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbKategori.FormattingEnabled = true;
			this.cmbKategori.Location = new System.Drawing.Point(125, 105);
			this.cmbKategori.Name = "cmbKategori";
			this.cmbKategori.Size = new System.Drawing.Size(180, 33);
			this.cmbKategori.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(23, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 24;
			this.label2.Text = "Kategori";
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAd.Location = new System.Drawing.Point(125, 52);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.Size = new System.Drawing.Size(180, 30);
			this.txtUrunAd.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(23, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "Ürün Adı";
			// 
			// btnTemizle
			// 
			this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.Location = new System.Drawing.Point(912, 106);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(126, 66);
			this.btnTemizle.TabIndex = 21;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = true;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// btnAra
			// 
			this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAra.Location = new System.Drawing.Point(912, 11);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(126, 67);
			this.btnAra.TabIndex = 20;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnEkle);
			this.panel2.Controls.Add(this.btnGuncelle);
			this.panel2.Controls.Add(this.btnSil);
			this.panel2.Controls.Add(this.btnKapat);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 508);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1053, 106);
			this.panel2.TabIndex = 4;
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
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 196);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1053, 312);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// FrmUrunListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 614);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "FrmUrunListesi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Listesi";
			this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbFiyat.ResumeLayout(false);
			this.gbFiyat.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbStokKücük;
		private System.Windows.Forms.RadioButton rbStokEsit;
		private System.Windows.Forms.RadioButton rbStokBüyük;
		private System.Windows.Forms.GroupBox gbFiyat;
		private System.Windows.Forms.RadioButton rdbKücük;
		private System.Windows.Forms.RadioButton rdbEsit;
		private System.Windows.Forms.RadioButton RdbBüyük;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbKategori;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}