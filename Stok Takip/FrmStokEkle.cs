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
	public partial class FrmStokEkle : Form
	{
		public FrmStokEkle()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtUrunStok_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		UrunBLL bll = new UrunBLL();
		UrunDTO dto = new UrunDTO();
		bool combofull = false;
		private void FrmStokEkle_Load(object sender, EventArgs e)
		{
			dto = bll.Select();
			dataGridView1.DataSource = dto.Urunler;
			cmbKategori.DataSource = dto.Kategoriler;
			cmbKategori.DisplayMember = "KategoriAD";
			cmbKategori.ValueMember = "ID";
			cmbKategori.SelectedIndex = -1;
			combofull = true;
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Ürün Ad";
			dataGridView1.Columns[2].HeaderText = "Kategori Ad";
			dataGridView1.Columns[3].HeaderText = "Stok Miktarı";
			dataGridView1.Columns[4].HeaderText = "Fiyat";
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[7].Visible = false;
		}

		private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull)
			{
				List<UrunDetayDTO> list = new List<UrunDetayDTO>();
				list = dto.Urunler;
				int kID = Convert.ToInt32(cmbKategori.SelectedValue);
				list=list.Where(x=>x.KategoriID ==kID).ToList();
				dataGridView1.DataSource = list; 
			}
			
		}

		private void btnHepsiniGetir_Click(object sender, EventArgs e)
		{
			cmbKategori.SelectedIndex = -1;
			dataGridView1.DataSource = dto.Urunler;
		}
		UrunDetayDTO detay = new UrunDetayDTO();
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			detay.StokMiktari = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
			detay.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
			detay.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

			txtUrunAd.Text = detay.UrunAd;
			txtUrunFiyat.Text = detay.Fiyat.ToString();

		
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(detay.ID == 0)
			{
				MessageBox.Show("Seçili ürün yok");
			}
			else if (txtUrunStok.Text.Length == 0)
			{
				MessageBox.Show("Stok miktarı giriniz");
			}
			else
			{
				detay.isStokEkleme = true;
				int toplam = detay.StokMiktari;
				toplam += Convert.ToInt32(txtUrunStok.Text);
				detay.StokMiktari = toplam;
				if (bll.Update(detay))
				{
					MessageBox.Show("Stok eklendi.");
					dto = bll.Select();
					dataGridView1.DataSource = dto.Urunler;
					txtUrunStok.Clear();
				}
			}
		}
	}
}
