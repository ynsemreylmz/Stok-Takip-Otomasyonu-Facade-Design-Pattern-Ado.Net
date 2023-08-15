using Stok_Takip.BLL;
using Stok_Takip.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip
{
	public partial class FrmSatisListesi : Form
	{
		public FrmSatisListesi()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtSatis_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			
			FrmSatis frm = new FrmSatis();
			
			frm.dto = dto;
			frm.isUpdate = false;
			this.Hide();
			frm.ShowDialog();
			this.Visible = true;
			bll = new SatisBLL();
			dto = bll.Select();
			dataGridView1.DataSource = dto.Satislar;
		}

		SatisDTO dto = new SatisDTO();
		SatisBLL bll = new	SatisBLL();

		private void FrmSatisListesi_Load(object sender, EventArgs e)
		{
			dto = bll.Select();
			cmbKategori.DataSource = dto.Kategoriler;
			cmbKategori.DisplayMember = "KategoriAD";
			cmbKategori.ValueMember = "ID";
			cmbKategori.SelectedIndex = -1;
			dataGridView1.DataSource = dto.Satislar;
		
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[7].Visible = false;
			dataGridView1.Columns[8].Visible = false;
			dataGridView1.Columns[9].Visible = false;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;
			dataGridView1.Columns[13].Visible = false;



		}

		private void btnAra_Click(object sender, EventArgs e)
		{
			List<SatisDetayDTO> list = dto.Satislar;

			if (txtUrunAd.Text.Length != 0)
			{
				list = list.Where(x => x.UrunAd.Contains(txtUrunAd.Text)).ToList();
			}

			if (txtMusteriAdi.Text.Length != 0)
			{
				list = list.Where(x => x.MusteriAd.Contains(txtMusteriAdi.Text)).ToList();
			}

			if (cmbKategori.SelectedIndex != -1)
			{
				list = list.Where(x => x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
			}

			if (RdbBüyük.Checked)
			{
				list = list.Where(x => x.Fiyat > Convert.ToInt32(txtFiyat.Text)).ToList();
			}

			if (rdbKücük.Checked)
			{
				list = list.Where(x => x.Fiyat < Convert.ToInt32(txtFiyat.Text)).ToList();
			}

			if (rdbEsit.Checked)
			{
				list = list.Where(x => x.Fiyat == Convert.ToInt32(txtFiyat.Text)).ToList();
			}

			if (rbSBüyük.Checked)
			{
				list = list.Where(x => x.SatisMiktari > Convert.ToInt32(txtSatis.Text)).ToList();
			}

			if (rbSKücük.Checked)
			{
				list = list.Where(x => x.SatisMiktari < Convert.ToInt32(txtSatis.Text)).ToList();
			}

			if (rbSEsit.Checked)
			{
				list = list.Where(x => x.SatisMiktari == Convert.ToInt32(txtSatis.Text)).ToList();
			}

			if (cbTarih.Checked)
			{
				list = list.Where(x=>x.SatisTarihi>dpBaslama.Value && x.SatisTarihi < dpBitis.Value).ToList();

			
			}
			dataGridView1.DataSource = list;
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
		void Temizle()
		{
			txtFiyat.Clear();
			txtMusteriAdi.Clear();
			txtSatis.Clear();
			txtUrunAd.Clear();
			cmbKategori.SelectedIndex = -1;
			rbSBüyük.Checked = false;
			rdbEsit.Checked = false;
			rdbKücük.Checked = false;
			RdbBüyük.Checked = false;
			rbSEsit.Checked = false;
			rbSEsit.Checked = false;
			dataGridView1.DataSource = dto.Urunler;
			dpBaslama.Value = DateTime.Today;
			dpBitis.Value = DateTime.Today;	
			cbTarih.Checked = false;
			dataGridView1.DataSource = dto.Satislar;
		}

		SatisDetayDTO detay = new SatisDetayDTO();

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			detay.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			detay.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
			detay.SatisID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
			detay.UrunID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
			detay.MusteriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
			detay.SatisMiktari = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if(detay.UrunID == 0)
			{
				MessageBox.Show("Seçim yapınız.");
			}
			else
			{
				FrmSatis frm = new FrmSatis();
				frm.dto = dto;
				frm.detayDTO = detay;
				frm.isUpdate = true;
				this.Hide();
				frm.ShowDialog();
				this.Visible = true;
				bll = new SatisBLL();
				dto = bll.Select();
				dataGridView1.DataSource = dto.Satislar;
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (detay.SatisID == 0)
				MessageBox.Show("Seçili öge bulunmadı.");
			DialogResult result = MessageBox.Show("Emin misiniz?","Dikkat" ,MessageBoxButtons.YesNo);
			if(result == DialogResult.Yes)
			{
				if (bll.Delete(detay))
				{
					MessageBox.Show("Silindi");
					bll = new SatisBLL();
					dto = bll.Select();
					dataGridView1.DataSource = dto.Satislar;
				}
			}
		}
	}
}
