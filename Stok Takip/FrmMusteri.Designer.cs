namespace Stok_Takip
{
	partial class FrmMusteri
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
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMusteriAdi = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnKapat
			// 
			this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKapat.Location = new System.Drawing.Point(288, 91);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(126, 55);
			this.btnKapat.TabIndex = 7;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Location = new System.Drawing.Point(156, 91);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(126, 55);
			this.btnKaydet.TabIndex = 6;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Müşteri Ad";
			// 
			// txtMusteriAdi
			// 
			this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMusteriAdi.Location = new System.Drawing.Point(156, 37);
			this.txtMusteriAdi.Name = "txtMusteriAdi";
			this.txtMusteriAdi.Size = new System.Drawing.Size(251, 30);
			this.txtMusteriAdi.TabIndex = 4;
			// 
			// FrmMusteri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 187);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMusteriAdi);
			this.Name = "FrmMusteri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşteri";
			this.Load += new System.EventHandler(this.FrmMusteri_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMusteriAdi;
	}
}