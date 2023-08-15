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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stok_Takip
{
	public partial class FrmSilinenler : Form
	{
		public FrmSilinenler()
		{
			InitializeComponent();
		}
		SatisDTO dto = new SatisDTO();
		SatisBLL bll = new SatisBLL();	
		private void FrmSilinenler_Load(object sender, EventArgs e)
		{
			cmbTablolar.Items.Add("Kategoriler");
			cmbTablolar.Items.Add("Ürünler");
			cmbTablolar.Items.Add("Müşteriler");
			cmbTablolar.Items.Add("Satış");
			dto = bll.Select(true);
			cmbTablolar.SelectedIndex = 3;
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

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmbTablolar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbTablolar.SelectedIndex == 0)
			{
				dto = bll.Select();
				dataGridView1.DataSource = dto.Kategoriler;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].HeaderText = "Kategori Adı";
			}
			else if(cmbTablolar.SelectedIndex == 1)
			{
				dataGridView1.DataSource = dto.Urunler;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].HeaderText = "Ürün Ad";
				dataGridView1.Columns[2].HeaderText = "Kategori Ad";
				dataGridView1.Columns[3].HeaderText = "Stok Miktarı";
				dataGridView1.Columns[4].HeaderText = "Fiyat";
				dataGridView1.Columns[5].Visible = false;
				dataGridView1.Columns[6].Visible = false;
				dataGridView1.Columns[7].Visible = false;
			}
			else if( cmbTablolar.SelectedIndex == 2)
			{
				dataGridView1.DataSource = dto.Musteriler;
				dataGridView1.Columns[0].Visible = false;
				dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
			}
			else if(cmbTablolar.SelectedIndex == 3)
			{
				
				dto = bll.Select(true);
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
		}
		SatisDetayDTO satisDetayDTO = new SatisDetayDTO();
		UrunDetayDTO UrunDetayDTO = new UrunDetayDTO();
		KategoriDetayDTO kategoriDetayDTO = new KategoriDetayDTO();
		MusteriDetayDTO MusteriDetayDTO = new MusteriDetayDTO();
		KategoriBLL kategoriBLL = new KategoriBLL();
		UrunBLL UrunBLL = new UrunBLL();
		MusteriBLL MusteriBLL = new MusteriBLL();


		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{

			if (cmbTablolar.SelectedIndex == 0)
			{
				kategoriDetayDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
				kategoriDetayDTO.KategoriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			}
			else if (cmbTablolar.SelectedIndex == 1)
			{
				UrunDetayDTO.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				UrunDetayDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
				UrunDetayDTO.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
				UrunDetayDTO.KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
				UrunDetayDTO.KategoriDeleted = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (cmbTablolar.SelectedIndex == 2)
			{
				MusteriDetayDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
				MusteriDetayDTO.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			}
			else
			{
				satisDetayDTO.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				satisDetayDTO.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				satisDetayDTO.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
				satisDetayDTO.SatisID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
				satisDetayDTO.UrunID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
				satisDetayDTO.MusteriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
				satisDetayDTO.SatisMiktari = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

			}
		}

		private void btnGeriGetir_Click(object sender, EventArgs e)
		{
			if (cmbTablolar.SelectedIndex == 0)
			{
				if (kategoriBLL.GetBack(kategoriDetayDTO))
				{
					MessageBox.Show("Geri Geldi");
					bll = new SatisBLL();
					dto = bll.Select();
					dataGridView1.DataSource = dto.Kategoriler;
				}
			}
			else if (cmbTablolar.SelectedIndex == 1)
			{
				if (UrunBLL.GetBack(UrunDetayDTO))
				{
					if (UrunDetayDTO.KategoriDeleted)
					{
						MessageBox.Show("Kateogri silindi, bu ürün geri getirelemez.");
					}
					else
					{
						MessageBox.Show("Geri Geldi");
						bll = new SatisBLL();
						dto = bll.Select();
						dataGridView1.DataSource = dto.Urunler;
					}
					
				}
			}
			else if (cmbTablolar.SelectedIndex == 2)
			{
				if (MusteriBLL.GetBack(MusteriDetayDTO))
				{
					MessageBox.Show("Geri Geldi");
					bll = new SatisBLL();
					dto = bll.Select();
					dataGridView1.DataSource = dto.Musteriler;
				}
			}
			else if(cmbTablolar.SelectedIndex == 3)
			{

				if (bll.GetBack(satisDetayDTO))
				{
					if (!satisDetayDTO.urundeleted && !satisDetayDTO.katdeleted && !satisDetayDTO.musDeleted)
					{
						MessageBox.Show("Bu satışa ait ürün, kateogri veya müşteri silindiği için geri getirilemez.");
					}
					else
					{
						MessageBox.Show("Geri Geldi");
						bll = new SatisBLL();
						dto = bll.Select();
						dataGridView1.DataSource = dto.Satislar;
					}
					
				}
			}
		}
	}
}
