using Stok_Takip.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip.DAL.DAO
{
	internal class MusteriDAO : StokContext, IDAO<MUSTERI, MusteriDetayDTO>
	{
		public bool Delete(MUSTERI entity)
		{
			MUSTERI mm = db.MUSTERI.First(x => x.ID == entity.ID);
			mm.isDeleted = true;
			mm.DeletedDate = DateTime.Today;
			db.SaveChanges();
			return true;
		}

		public bool GetBack(int ID)
		{
			MUSTERI mm = db.MUSTERI.First(x=> x.ID == ID);
			mm.isDeleted = false;
			db.SaveChanges();
			return true;
		}

		public bool Insert(MUSTERI entity)
		{
			try
			{
				db.MUSTERI.Add(entity);
				db.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public List<MusteriDetayDTO> Select()
		{
			try
			{
				List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
				var list = db.MUSTERI.Where(x=>x.isDeleted==false);
                foreach (var item in list)
                {
                    MusteriDetayDTO dto = new MusteriDetayDTO();
					dto.ID = item.ID;
					dto.MusteriAd = item.MusteriAd;
					liste.Add(dto);
                }
				return liste;
            }
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public List<MusteriDetayDTO> Select(bool deleted)
		{
			try
			{
				List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
				var list = db.MUSTERI.Where(x => x.isDeleted == true);
				foreach (var item in list)
				{
					MusteriDetayDTO dto = new MusteriDetayDTO();
					dto.ID = item.ID;
					dto.MusteriAd = item.MusteriAd;
					liste.Add(dto);
				}
				return liste;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public bool Update(MUSTERI entity)
		{
			try
			{
				MUSTERI mus = db.MUSTERI.First(x => x.ID == entity.ID);
				mus.MusteriAd = entity.MusteriAd; 
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
