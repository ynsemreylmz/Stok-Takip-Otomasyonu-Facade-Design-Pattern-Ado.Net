using Stok_Takip.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip.DAL.DAO
{
	internal class SatisDAO : StokContext, IDAO<SATIM, SatisDetayDTO>
	{
		public bool Delete(SATIM entity)
		{
			try
			{	
				if(entity.ID != 0)
				{
					SATIM satis = db.SATIM.First(x => x.ID == entity.ID);
					satis.isDeleted = true;
					satis.DeletedDate = DateTime.Now;
					
				}
				else if(entity.UrunID !=0)
				{
					List<SATIM> list = db.SATIM.Where(x=>x.UrunID == entity.UrunID).ToList();
					foreach(SATIM sat in list)
					{
						sat.isDeleted = true;
						sat.DeletedDate = DateTime.Now;

					}
				}
				db.SaveChanges();
				return true;
				
				
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public bool GetBack(int ID)
		{
			SATIM ss = db.SATIM.First(x=>x.ID == ID);
			ss.isDeleted = false;
			db.SaveChanges();
			return true;
		}

		public bool Insert(SATIM entity)
		{
			try
			{
				db.SATIM.Add(entity);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public List<SatisDetayDTO> Select()
		{
			try
			{
				List<SatisDetayDTO> liste = new List<SatisDetayDTO>();

				var list = (from s in db.SATIM.Where(x=>x.isDeleted==false)
							join u in db.URUN on s.UrunID equals u.ID
							join k in db.KATEGORI on s.KategoriID equals k.ID
							join m in db.MUSTERI on s.MusterID equals m.ID
							select new
							{
								musteriad = m.MusteriAd,
								urunad = u.UrunAd,
								kategoriad = k.KategoriAd,
								fiyat = s.SatisFiyat,
								satistarih = s.SatisTarih,
								satismiktari = s.SatisMiktar,
								stok = u.Stok,
								satisID = s.ID,
								urunID = s.UrunID,
								musteriıd = s.MusterID,
								kategoriID = s.KategoriID
							}).OrderBy(x => x.satistarih);

				foreach (var item in list)
				{
					SatisDetayDTO dto = new SatisDetayDTO();
					dto.MusteriAd = item.musteriad;
					dto.UrunAd = item.urunad;
					dto.KategoriAd = item.kategoriad;
					dto.Fiyat = item.fiyat;
					dto.SatisTarihi = item.satistarih;
					dto.SatisMiktari = item.satismiktari;
					dto.StokMiktar = item.stok;
					dto.SatisID = item.satisID;
					dto.UrunID = item.urunID;
					dto.MusteriID = item.musteriıd;
					dto.KategoriID = item.kategoriID;
					liste.Add(dto);
				}
				return liste;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public List<SatisDetayDTO> Select(bool deleted)
		{
			try
			{
				List<SatisDetayDTO> liste = new List<SatisDetayDTO>();

				var list = (from s in db.SATIM.Where(x => x.isDeleted == true)
							join u in db.URUN on s.UrunID equals u.ID
							join k in db.KATEGORI on s.KategoriID equals k.ID
							join m in db.MUSTERI on s.MusterID equals m.ID
							select new
							{
								musteriad = m.MusteriAd,
								urunad = u.UrunAd,
								kategoriad = k.KategoriAd,
								fiyat = s.SatisFiyat,
								satistarih = s.SatisTarih,
								satismiktari = s.SatisMiktar,
								stok = u.Stok,
								satisID = s.ID,
								urunID = s.UrunID,
								musteriıd = s.MusterID,
								kategoriID = s.KategoriID,
								kateegorideleted = k.isDeleted,
								musterideleted = m.isDeleted,
								urundeleted = u.isDeleted
							}).OrderBy(x => x.satistarih);

				foreach (var item in list)
				{
					SatisDetayDTO dto = new SatisDetayDTO();
					dto.MusteriAd = item.musteriad;
					dto.UrunAd = item.urunad;
					dto.KategoriAd = item.kategoriad;
					dto.Fiyat = item.fiyat;
					dto.SatisTarihi = item.satistarih;
					dto.SatisMiktari = item.satismiktari;
					dto.StokMiktar = item.stok;
					dto.SatisID = item.satisID;
					dto.UrunID = item.urunID;
					dto.MusteriID = item.musteriıd;
					dto.KategoriID = item.kategoriID;
					dto.musDeleted = item.musterideleted;
					dto.urundeleted = item.urundeleted;
					dto.katdeleted = item.kateegorideleted;
					liste.Add(dto);
				}
				return liste;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public bool Update(SATIM entity)
		{
			SATIM ss = db.SATIM.First(x => x.ID == entity.ID);
			ss.SatisMiktar = entity.SatisMiktar;
			db.SaveChanges();
			return true;
		}
	}
}
