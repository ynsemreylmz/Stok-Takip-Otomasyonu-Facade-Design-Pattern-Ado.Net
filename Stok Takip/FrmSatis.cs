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
using System.Windows.Forms.VisualStyles;

namespace Stok_Takip
{
	public partial class FrmSatis : Form
	{
		public FrmSatis()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtSatisMiktari_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		public SatisDTO dto = new SatisDTO();

		public SatisDetayDTO detayDTO = new SatisDetayDTO();
		public bool isUpdate = false;

		private void FrmSatis_Load(object sender, EventArgs e)
		{
			if (isUpdate)
			{
				panel1.Visible = false;
				txtMusteri.Text = detayDTO.MusteriAd;
				txtUrunAd.Text = detayDTO.UrunAd;
				txtUrunFiyat.Text = detayDTO.Fiyat.ToString();
				List<UrunDetayDTO> urunler = dto.Urunler;
				UrunDetayDTO urun = urunler.First(x => x.ID == detayDTO.UrunID);
				txtStok.Text = urun.StokMiktari.ToString();
			}
			else
			{
				gridMusteriler.DataSource = dto.Musteriler;
				gridMusteriler.Columns[0].Visible = false;
				gridMusteriler.Columns[1].HeaderText = "Müteri Ad";
				GridUrunler.DataSource = dto.Urunler;
				GridUrunler.Columns[0].Visible = false;
				GridUrunler.Columns[5].Visible = false;
				GridUrunler.Columns[6].Visible = false;
				GridUrunler.Columns[7].Visible = false;
				GridUrunler.Columns[3].Visible = false;
				GridUrunler.Columns[4].Visible = false;
				GridUrunler.Columns[1].HeaderText = "Ürün Ad";
				GridUrunler.Columns[2].HeaderText = "Kategori Ad";

				cmbKategori.DataSource = dto.Kategoriler;
				cmbKategori.DisplayMember = "KategoriAD";
				cmbKategori.ValueMember = "ID";
				cmbKategori.SelectedIndex = -1;
				if (dto.Kategoriler.Count > 0)
				{
					combofull = true;
				}
			}


		}
		bool combofull = false;
		private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(combofull)
			{
				List<UrunDetayDTO> list = dto.Urunler;
				if(cmbKategori.SelectedIndex != -1)
				{ 
					list = list.Where(x=>x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();	
					GridUrunler.DataSource = list;
				}
			}
		}

		private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
		{
			List<MusteriDetayDTO> list = dto.Musteriler.Where(x => x.MusteriAd.Contains(txtMusteriAdi.Text)).ToList();
			gridMusteriler.DataSource = list;

		}
		SatisDetayDTO detay = new SatisDetayDTO();
		private void GridUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.UrunID = Convert.ToInt32(GridUrunler.Rows[e.RowIndex].Cells[0].Value);
			detay.Fiyat = Convert.ToInt32(GridUrunler.Rows[e.RowIndex].Cells[4].Value);
			detay.StokMiktar = Convert.ToInt32(GridUrunler.Rows[e.RowIndex].Cells[3].Value);
			detay.KategoriID = Convert.ToInt32(GridUrunler.Rows[e.RowIndex].Cells[5].Value);
			detay.UrunAd = GridUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();

			txtStok.Text = detay.StokMiktar.ToString();
			txtUrunAd.Text = detay.UrunAd.ToString();
			txtUrunFiyat.Text = detay.Fiyat.ToString();
		}

		private void gridMusteriler_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.MusteriID = Convert.ToInt32(gridMusteriler.Rows[e.RowIndex].Cells[0].Value);
			detay.MusteriAd = gridMusteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtMusteri.Text = detay.MusteriAd.ToString();

		}
		SatisBLL bll = new SatisBLL();
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (txtSatisMiktari.Text.Trim() == "")
				MessageBox.Show("Gerekli tüm alanları doldurunuz.");
			
			else
			{
				if (isUpdate)
				{

					int temp = detayDTO.SatisMiktari + Convert.ToInt32(txtStok.Text);
					if (temp <= Convert.ToInt32(txtSatisMiktari.Text))
						MessageBox.Show("Yeterli stok yok");
					else
					{
						detayDTO.SatisMiktari = Convert.ToInt32(txtSatisMiktari.Text);
						detayDTO.StokMiktar = Convert.ToInt32(txtStok.Text);
						if (bll.Update(detayDTO))
						{
							MessageBox.Show("Güncellendi");
							this.Close();
						}
					}



				}
				else
				{

					if (detay.UrunID == 0)
						MessageBox.Show("Gerekli tüm alanları doldurunuz.");
					else if (detay.MusteriID == 0)
						MessageBox.Show("Gerekli tüm alanları doldurunuz.");
					else if (detay.StokMiktar <= Convert.ToInt32(txtSatisMiktari.Text))
						MessageBox.Show("Yeterli stok yok");
					else
					{
						detay.SatisMiktari = Convert.ToInt32(txtSatisMiktari.Text);
						if (bll.Insert(detay))
						{
							MessageBox.Show("Eklendi");
							txtSatisMiktari.Clear();
							dto = bll.Select();
							GridUrunler.DataSource = dto.Urunler;
						}
					}
					
				}
				
			}
		}
	}
}
