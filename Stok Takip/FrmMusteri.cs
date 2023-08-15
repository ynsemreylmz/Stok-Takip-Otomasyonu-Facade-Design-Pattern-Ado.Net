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
	public partial class FrmMusteri : Form
	{
		public FrmMusteri()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		MusteriDetayDTO detay = new MusteriDetayDTO();	
		MusteriBLL bll = new MusteriBLL();
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (txtMusteriAdi.Text.Trim() == "")
				MessageBox.Show("Müşteri adı giriniz.");
			else
			{
				if (isUpdate)
				{
					detaydto.MusteriAd = txtMusteriAdi.Text;
					if (bll.Update(detaydto))
					{
						MessageBox.Show("Güncellendi");
						this.Close();
					}
				}
				else
				{
					detay.MusteriAd = txtMusteriAdi.Text;
					if (bll.Insert(detay))
					{
						MessageBox.Show("Eklendi");
						txtMusteriAdi.Clear();

					}
				}
				
			}
		}
		public MusteriDetayDTO detaydto = new MusteriDetayDTO();
		public bool isUpdate = false;
		private void FrmMusteri_Load(object sender, EventArgs e)
		{
			if(isUpdate)
			{
				txtMusteriAdi.Text = detaydto.MusteriAd;
				
			}
		}
	}
}
