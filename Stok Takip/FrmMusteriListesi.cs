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
	public partial class FrmMusteriListesi : Form
	{
		public FrmMusteriListesi()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			FrmMusteri frm = new FrmMusteri();
			frm.isUpdate = false;
			this.Hide();
			frm.ShowDialog();
			this.Visible = true;

			dto = bll.Select();
			dataGridView1.DataSource = dto.Musteriler;
		}

		MusteriDTO dto = new MusteriDTO();
		MusteriBLL bll = new MusteriBLL();
		MusteriDetayDTO detay= new MusteriDetayDTO();
		private void FrmMusteriListesi_Load(object sender, EventArgs e)
		{
			dto = bll.Select();
			dataGridView1.DataSource = dto.Musteriler;
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			detay.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (detay.ID == 0)
				MessageBox.Show("Seçim yapınız");
			else
			{
				FrmMusteri frm = new FrmMusteri();
				frm.isUpdate = true;
				frm.detaydto = detay;
				this.Hide();
				frm.ShowDialog();
				this.Visible = true;
				bll = new MusteriBLL();
				dto = bll.Select();
				dataGridView1.DataSource = dto.Musteriler;

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
						bll = new MusteriBLL();
						dto = bll.Select();
						dataGridView1.DataSource = dto.Musteriler;

					}

				}
			}
		}
	}
}
