using Stok_Takip.DAL;
using Stok_Takip.DAL.DAO;
using Stok_Takip.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip.BLL
{
	internal class KategoriBLL : IBLL<KategoriDetayDTO, KategoriDTO>
	{

		KategoriDAO dao = new KategoriDAO();
		UrunDAO UrunDAO = new UrunDAO();
		public bool Delete(KategoriDetayDTO entity)
		{
			KATEGORI kategori = new KATEGORI();
			kategori.ID = entity.ID;
			dao.Delete(kategori);
			URUN urun = new URUN();
			urun.KategoriID = entity.ID;
			UrunDAO.Delete(urun);
			return true;
		}

		public bool GetBack( KategoriDetayDTO entity)
		{
			return dao.GetBack(entity.ID);
		}

		public bool Insert(KategoriDetayDTO entity)
		{
			KATEGORI kategori = new KATEGORI();
			kategori.KategoriAd=entity.KategoriAd;
			kategori.isDeleted = false;
			return dao.Insert(kategori);
		}

		public KategoriDTO Select()
		{
			KategoriDTO dto = new KategoriDTO();
			dto.Kategoriler = dao.Select();
			return dto;
		}

		public bool Update(KategoriDetayDTO entity)
		{
			KATEGORI kt = new KATEGORI();
			kt.ID = entity.ID;	
			kt.KategoriAd = entity.KategoriAd;
			return dao.Update(kt);
		}
	}
}
