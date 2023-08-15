﻿using Stok_Takip.BLL;
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
	public partial class FrmKategoriListesi : Form
	{
		public FrmKategoriListesi()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Listele()
		{
			bll = new KategoriBLL();
			dto = bll.Select();
			dataGridView1.DataSource = dto.Kategoriler;
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Kategori Adı";
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			FrmKategori frm = new FrmKategori();
			frm.isUpdate = false;
			this.Hide();
			frm.ShowDialog();
			this.Visible = true;
			Listele();


		}

		KategoriDTO dto = new KategoriDTO();
		KategoriBLL bll = new KategoriBLL();
		private void FrmKategoriListesi_Load(object sender, EventArgs e)
		{
			Listele();
			


		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			List<KategoriDetayDTO> list = new List<KategoriDetayDTO>();
			list = dto.Kategoriler.Where(x => x.KategoriAd.Contains(txtKategori.Text)).ToList();
			dataGridView1.DataSource =list;

			

		}
		KategoriDetayDTO detay = new KategoriDetayDTO();
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			detay.KategoriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (detay.ID == 0)
				MessageBox.Show("Kategori Seçiniz.");
			else
			{
				
			
				FrmKategori frm = new FrmKategori();
				frm.isUpdate = true;
				frm.detay = detay;
				this.Hide();
				frm.ShowDialog();
				this.Visible = true;
				Listele();

			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (detay.ID == 0)
			{
				MessageBox.Show("Kateogir Seçiniz.");
			}
			else
			{
				DialogResult result = MessageBox.Show("Silinsin mi?", "", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{

					if (bll.Delete(detay))
					{
						MessageBox.Show("Silindi");
						bll = new KategoriBLL();
						dto = bll.Select();
						dataGridView1.DataSource = dto.Kategoriler;

					}

				}
			}
		}
	}
}
