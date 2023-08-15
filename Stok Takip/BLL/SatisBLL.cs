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
	internal class SatisBLL : IBLL<SatisDetayDTO, SatisDTO>
	{
		KategoriDAO kategoriDAO = new KategoriDAO();
		MusteriDAO musteriDAO = new MusteriDAO();
		UrunDAO urunDAO = new UrunDAO();
		SatisDAO dao = new SatisDAO();


		public bool Delete(SatisDetayDTO entity)
		{
			SATIM satis = new SATIM();
			satis.ID = entity.SatisID;
			dao.Delete(satis);
			urunDAO.StokGuncelle(entity);
			return true;

		}

		public bool GetBack(SatisDetayDTO entity)
		{
			dao.GetBack(entity.SatisID);
			URUN urun = new URUN();
			urun.ID = entity.UrunID;
			int temp = entity.StokMiktar + entity.SatisMiktari;
			urun.Stok = temp;
			urunDAO.Update(urun);
			return true;
		}

		public bool Insert(SatisDetayDTO entity)
		{
			SATIM satis = new SATIM();
			satis.UrunID = entity.UrunID;
			satis.MusterID = entity.MusteriID;
			satis.SatisMiktar = entity.SatisMiktari;
			satis.SatisTarih = DateTime.Today;
			satis.SatisFiyat = entity.Fiyat;
			satis.KategoriID = entity.KategoriID;
			dao.Insert(satis);

			URUN urun = new URUN();
			urun.ID = entity.UrunID;
			int temp = entity.StokMiktar - entity.SatisMiktari;
			urun.Stok = temp;
			urunDAO.Update(urun);
			return true;
		}

		public SatisDTO Select()
		{
			SatisDTO dto = new SatisDTO();
			dto.Kategoriler = kategoriDAO.Select();
			dto.Musteriler = musteriDAO.Select();
			dto.Urunler = urunDAO.Select();
			dto.Satislar = dao.Select();
			return dto;

		}
		public SatisDTO Select(bool deleted)
		{
			SatisDTO dto = new SatisDTO();
			dto.Kategoriler = kategoriDAO.Select(deleted);
			dto.Musteriler = musteriDAO.Select(deleted);
			dto.Urunler = urunDAO.Select(deleted);
			dto.Satislar = dao.Select(deleted);
			return dto;

		}

		public bool Update(SatisDetayDTO entity)
		{	

			SATIM satis = new SATIM();
			satis.SatisMiktar = entity.SatisMiktari;
			satis.ID = entity.SatisID;
			dao.Update(satis);
			int temp = entity.StokMiktar;
			URUN urun = new URUN();
			urun.Stok = entity.StokMiktar - (entity.SatisMiktari - temp);
			urun.ID=entity.UrunID;
			urunDAO.Update(urun);
			return true;
		}
	}
}
