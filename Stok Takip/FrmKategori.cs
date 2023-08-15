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
	public partial class FrmKategori : Form
	{
		public FrmKategori()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		KategoriBLL bll = new KategoriBLL();

		public KategoriDetayDTO detay = new KategoriDetayDTO();
		public bool isUpdate = false;

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			
			if (txtKategori.Text.Trim() == "")
				MessageBox.Show("Kategori yazınız.");
			else
			{
				
				if (isUpdate)
				{
					
						detay.KategoriAd = txtKategori.Text;
						
						if (bll.Update(detay))
						{
							MessageBox.Show("Güncellendi");
							this.Close();
							
						}
					
				}
				else
				{
					KategoriDetayDTO detay = new KategoriDetayDTO();
					detay.KategoriAd = txtKategori.Text;
					if (bll.Insert(detay))
					{
						MessageBox.Show("Başarılı bir şekilde eklendi.");
						txtKategori.Clear();
					}
				}
				
			}
		}

		
		private void FrmKategori_Load(object sender, EventArgs e)
		{
			if(isUpdate)
			{
				txtKategori.Text = detay.KategoriAd;

			}
		}
	}
}
