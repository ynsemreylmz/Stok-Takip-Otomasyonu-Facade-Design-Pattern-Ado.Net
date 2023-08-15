namespace Stok_Takip
{
	partial class FrmStokEkle
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmbKategori = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrunFiyat = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUrunStok = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnHepsiniGetir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(384, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 545);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnHepsiniGetir);
			this.panel2.Controls.Add(this.cmbKategori);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(416, 135);
			this.panel2.TabIndex = 0;
			// 
			// cmbKategori
			// 
			this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbKategori.FormattingEnabled = true;
			this.cmbKategori.Location = new System.Drawing.Point(131, 34);
			this.cmbKategori.Name = "cmbKategori";
			this.cmbKategori.Size = new System.Drawing.Size(180, 33);
			this.cmbKategori.TabIndex = 15;
			this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(29, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 14;
			this.label2.Text = "Kategori";
			// 
			// txtUrunFiyat
			// 
			this.txtUrunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunFiyat.Location = new System.Drawing.Point(179, 59);
			this.txtUrunFiyat.Name = "txtUrunFiyat";
			this.txtUrunFiyat.ReadOnly = true;
			this.txtUrunFiyat.Size = new System.Drawing.Size(180, 30);
			this.txtUrunFiyat.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(47, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "Ürün Fiyatı";
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunAd.Location = new System.Drawing.Point(179, 16);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.ReadOnly = true;
			this.txtUrunAd.Size = new System.Drawing.Size(180, 30);
			this.txtUrunAd.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(47, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 15;
			this.label4.Text = "Ürün Adı";
			// 
			// txtUrunStok
			// 
			this.txtUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUrunStok.Location = new System.Drawing.Point(179, 105);
			this.txtUrunStok.Name = "txtUrunStok";
			this.txtUrunStok.Size = new System.Drawing.Size(180, 30);
			this.txtUrunStok.TabIndex = 20;
			this.txtUrunStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunStok_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(47, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 25);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ürün Stok";
			// 
			// btnKaydet
			// 
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(52, 159);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(126, 55);
			this.btnKaydet.TabIndex = 23;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKapat.Location = new System.Drawing.Point(233, 159);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(126, 55);
			this.btnKapat.TabIndex = 22;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnHepsiniGetir
			// 
			this.btnHepsiniGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnHepsiniGetir.Location = new System.Drawing.Point(131, 73);
			this.btnHepsiniGetir.Name = "btnHepsiniGetir";
			this.btnHepsiniGetir.Size = new System.Drawing.Size(180, 36);
			this.btnHepsiniGetir.TabIndex = 24;
			this.btnHepsiniGetir.Text = "Hepsini Getir";
			this.btnHepsiniGetir.UseVisualStyleBackColor = true;
			this.btnHepsiniGetir.Click += new System.EventHandler(this.btnHepsiniGetir_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 135);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(416, 410);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// FrmStokEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 545);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.txtUrunStok);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUrunFiyat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUrunAd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Name = "FrmStokEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Stok Ekle";
			this.Load += new System.EventHandler(this.FrmStokEkle_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cmbKategori;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrunFiyat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUrunStok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnHepsiniGetir;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}