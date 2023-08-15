namespace Stok_Takip
{
	partial class FrmSatis
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gridMusteriler = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMusteriAdi = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.GridUrunler = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmbKategori = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMusteri = new System.Windows.Forms.TextBox();
			this.txtUrunFiyat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSatisMiktari = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).BeginInit();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(359, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 628);
			this.panel1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gridMusteriler);
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 304);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(402, 324);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Müşteriler";
			// 
			// gridMusteriler
			// 
			this.gridMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMusteriler.Location = new System.Drawing.Point(3, 89);
			this.gridMusteriler.Name = "gridMusteriler";
			this.gridMusteriler.ReadOnly = true;
			this.gridMusteriler.RowHeadersWidth = 51;
			this.gridMusteriler.RowTemplate.Height = 24;
			this.gridMusteriler.Size = new System.Drawing.Size(396, 232);
			this.gridMusteriler.TabIndex = 2;
			this.gridMusteriler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMusteriler_RowEnter);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtMusteriAdi);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 18);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(396, 71);
			this.panel3.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(34, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "Müşteri Ad";
			// 
			// txtMusteriAdi
			// 
			this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMusteriAdi.Location = new System.Drawing.Point(174, 22);
			this.txtMusteriAdi.Name = "txtMusteriAdi";
			this.txtMusteriAdi.Size = new System.Drawing.Size(180, 30);
			this.txtMusteriAdi.TabIndex = 8;
			this.txtMusteriAdi.TextChanged += new System.EventHandler(this.txtMusteriAdi_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.GridUrunler);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(402, 304);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ürünler";
			// 
			// GridUrunler
			// 
			this.GridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.GridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridUrunler.Location = new System.Drawing.Point(3, 89);
			this.GridUrunler.Name = "GridUrunler";
			this.GridUrunler.ReadOnly = true;
			this.GridUrunler.RowHeadersWidth = 51;
			this.GridUrunler.RowTemplate.Height = 24;
			this.GridUrunler.Size = new System.Drawing.Size(396, 212);
			this.GridUrunler.TabIndex = 1;
			this.GridUrunler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUrunler_RowEnter);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmbKategori);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 18);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(396, 71);
			this.panel2.TabIndex = 0;
			// 
			// cmbKategori
			// 
			this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbKategori.FormattingEnabled = true;
			this.cmbKategori.Location = new System.Drawing.Point(174, 18);
			this.cmbKategori.Name = "cmbKategori";
			this.cmbKategori.Size = new System.Drawing.Size(180, 33);
			this.cmbKategori.TabIndex = 15;
			this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(57, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Kategori";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(26, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Müşteri Ad";
			// 
			// txtMusteri
			// 
			this.txtMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMusteri.Location = new System.Drawing.Point(158, 37);
			this.txtMusteri.Name = "txtMusteri";
			this.txtMusteri.ReadOnly = true;
			this.txtMusteri.Size = new System.Drawing.Size(180, 30);
			this.txtMusteri.TabIndex = 10;
			// 
			// txtUrunFiyat
			// 
			this.txtUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunFiyat.Location = new System.Drawing.Point(158, 134);
			this.txtUrunFiyat.Name = "txtUrunFiyat";
			this.txtUrunFiyat.ReadOnly = true;
			this.txtUrunFiyat.Size = new System.Drawing.Size(180, 30);
			this.txtUrunFiyat.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(26, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 25);
			this.label4.TabIndex = 17;
			this.label4.Text = "Ürün Fiyatı";
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAd.Location = new System.Drawing.Point(158, 87);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.ReadOnly = true;
			this.txtUrunAd.Size = new System.Drawing.Size(180, 30);
			this.txtUrunAd.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(26, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ürün Adı";
			// 
			// txtStok
			// 
			this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtStok.Location = new System.Drawing.Point(158, 179);
			this.txtStok.Name = "txtStok";
			this.txtStok.ReadOnly = true;
			this.txtStok.Size = new System.Drawing.Size(180, 30);
			this.txtStok.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(26, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Ürün Stok";
			// 
			// txtSatisMiktari
			// 
			this.txtSatisMiktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSatisMiktari.Location = new System.Drawing.Point(158, 224);
			this.txtSatisMiktari.Name = "txtSatisMiktari";
			this.txtSatisMiktari.Size = new System.Drawing.Size(180, 30);
			this.txtSatisMiktari.TabIndex = 20;
			this.txtSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisMiktari_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(26, 227);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 25);
			this.label7.TabIndex = 21;
			this.label7.Text = "Satış Miktarı";
			// 
			// btnKapat
			// 
			this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKapat.Location = new System.Drawing.Point(201, 273);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(137, 55);
			this.btnKapat.TabIndex = 23;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(31, 273);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(137, 55);
			this.btnKaydet.TabIndex = 22;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// FrmSatis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 628);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSatisMiktari);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtUrunFiyat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUrunAd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMusteri);
			this.Controls.Add(this.panel1);
			this.Name = "FrmSatis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Satış";
			this.Load += new System.EventHandler(this.FrmSatis_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView gridMusteriler;
		private System.Windows.Forms.DataGridView GridUrunler;
		private System.Windows.Forms.ComboBox cmbKategori;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMusteriAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMusteri;
		private System.Windows.Forms.TextBox txtUrunFiyat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSatisMiktari;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnKaydet;
	}
}