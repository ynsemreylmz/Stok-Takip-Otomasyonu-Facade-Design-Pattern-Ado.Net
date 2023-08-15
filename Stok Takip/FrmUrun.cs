using Stok_Takip.BLL;
using Stok_Takip.DAL.DAO;
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
	public partial class FrmUrun : Form
	{
		public FrmUrun()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtUrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		public UrunDTO dto = new UrunDTO();
		UrunBLL bll = new UrunBLL();
		UrunDetayDTO detay = new UrunDetayDTO();
		public UrunDetayDTO detayDto = new UrunDetayDTO();
		public bool isUpdate = false;
		private void FrmUrun_Load(object sender, EventArgs e)
		{
			cmbKategori.DataSource = dto.Kategoriler;
			cmbKategori.DisplayMember = "KategoriAD";
			cmbKategori.ValueMember = "ID";
			cmbKategori.SelectedIndex = -1;
			if (isUpdate)
			{
				txtUrunAd.Text = detayDto.UrunAd;
				txtUrunFiyat.Text = detayDto.Fiyat.ToString();
				cmbKategori.SelectedValue = detayDto.KategoriID;

			}
		}

		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(txtUrunAd.Text.Length == 0)
			{
				MessageBox.Show("Ürün alanı boş olamaz.");
			}
			else if (txtUrunFiyat.Text.Length == 0)
			{
				MessageBox.Show("Fiyat alanı boş olamaz.");
			}
			else if (cmbKategori.SelectedIndex == -1)
			{
				MessageBox.Show("Kategori alanı boş olamaz.");
			}
			else
			{

				if (isUpdate)
				{

					detayDto.UrunAd = txtUrunAd.Text;
					detayDto.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
					detayDto.Fiyat = Convert.ToInt32(txtUrunFiyat.Text);
					if (bll.Update(detayDto))
					{
						MessageBox.Show("Güncellendi.");
						this.Close();
					}
					


				}
				else
				{
					detay.UrunAd = txtUrunAd.Text;
					detay.Fiyat = Convert.ToInt32(txtUrunFiyat.Text);
					detay.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);

					if (bll.Insert(detay))
					{
						MessageBox.Show("Eklendi");
						txtUrunAd.Clear();
						txtUrunFiyat.Clear();
						cmbKategori.SelectedIndex = -1;
					}
				}


				

			}
		}
	}
}
