using Stok_Takip.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip.DAL.DAO
{
	internal class UrunDAO : StokContext, IDAO<URUN, UrunDetayDTO>
	{
		public void StokGuncelle(SatisDetayDTO entity)
		{
			URUN urun = db.URUN.First(x=>x.ID == entity.UrunID);
			int temp = urun.Stok + entity.SatisMiktari;
			urun.Stok = temp;
			db.SaveChanges();
			
		}

		public bool Delete(URUN entity)
		{	
			if(entity.ID != 0)
			{
				URUN urun = db.URUN.First(x => x.ID == entity.ID);
				urun.isDeleted = true;
				urun.DeleteDate = DateTime.Now;
				db.SaveChanges();
				
			}
			else if (entity.KategoriID !=0)
			{
				List<URUN> list = db.URUN.Where(x=>x.KategoriID == entity.KategoriID).ToList();
				foreach (var item in list)
				{
					item.isDeleted = true;
					item.DeleteDate = DateTime.Now;
					List<SATIM> satis = db.SATIM.Where(x => x.UrunID == item.ID).ToList();
					foreach (var item2 in satis)
					{
						
						item2.isDeleted = true;
						item2.DeletedDate = DateTime.Now;
					}
					db.SaveChanges();
				}
				db.SaveChanges();
				
			}
			return true;
		}

		public bool GetBack(int ID)
		{
			URUN urun = db.URUN.First(x=>x.ID==ID);
			urun.isDeleted = false;
			db.SaveChanges();
			return true;
		}

		public bool Insert(URUN entity)
		{
			try
			{	
				db.URUN.Add(entity);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public List<UrunDetayDTO> Select()
		{
			List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
			
			var list = (from u in db.URUN.Where(x=>x.isDeleted == false) join 
						k in db.KATEGORI on u.KategoriID equals k.ID
						select new
						{urunad=u.UrunAd,
						stok = u.Stok,
						fiyat = u.Fiyat,
						urunID = u.ID,
						kategoriAd = k.KategoriAd,
						kategoriID = k.ID,
						}).OrderBy(x=>x.urunad).ToList();

			foreach (var item in list)
			{
				UrunDetayDTO dto = new UrunDetayDTO();
				dto.Fiyat = item.fiyat;
				dto.ID = item.urunID;
				dto.KategoriAd = item.kategoriAd;
				dto.KategoriID = item.kategoriID;
				dto.StokMiktari = item.stok;
				dto.UrunAd = item.urunad;
				liste.Add(dto);
			}

			return liste;
		}
		public List<UrunDetayDTO> Select(bool deleted)
		{
			List<UrunDetayDTO> liste = new List<UrunDetayDTO>();

			var list = (from u in db.URUN.Where(x => x.isDeleted == true)
						join
						k in db.KATEGORI on u.KategoriID equals k.ID
						select new
						{
							urunad = u.UrunAd,
							stok = u.Stok,
							fiyat = u.Fiyat,
							urunID = u.ID,
							kategoriAd = k.KategoriAd,
							kategoriID = k.ID,
							kategoriDeleted = k.isDeleted
						}).OrderBy(x => x.urunad).ToList();

			foreach (var item in list)
			{
				UrunDetayDTO dto = new UrunDetayDTO();
				dto.Fiyat = item.fiyat;
				dto.ID = item.urunID;
				dto.KategoriAd = item.kategoriAd;
				dto.KategoriID = item.kategoriID;
				dto.StokMiktari = item.stok;
				dto.UrunAd = item.urunad;
				dto.KategoriDeleted = item.kategoriDeleted;
				liste.Add(dto);
			}

			return liste;
		}
		public bool Update(URUN entity)
		{
			try
			{
				URUN urun = db.URUN.First(x=>x.ID == entity.ID);
				if(entity.Fiyat == 0)
				{
					urun.Stok = entity.Stok;
				}
				else
				{
					urun.KategoriID = entity.KategoriID;
					urun.UrunAd = entity.UrunAd;
					urun.Fiyat = entity.Fiyat;
				}
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
