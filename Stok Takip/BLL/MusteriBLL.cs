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
	internal class MusteriBLL : IBLL<MusteriDetayDTO, MusteriDTO>
	{

		MusteriDAO dao = new MusteriDAO();

		public bool Delete(MusteriDetayDTO entity)
		{
			MUSTERI müsteri = new MUSTERI();
			müsteri.ID = entity.ID;
			dao.Delete(müsteri);
			return true;
		}

		public bool GetBack( MusteriDetayDTO entity)
		{
			return dao.GetBack(entity.ID);
		}

		public bool Insert(MusteriDetayDTO entity)
		{
			MUSTERI müsteri = new MUSTERI();
			müsteri.MusteriAd = entity.MusteriAd;
			müsteri.isDeleted = false;
			return dao.Insert(müsteri);
		}

		public MusteriDTO Select()
		{
			MusteriDTO dto = new MusteriDTO();
			dto.Musteriler = dao.Select();
			return dto;
		}

		public bool Update(MusteriDetayDTO entity)
		{
			MUSTERI musteri = new MUSTERI();
			musteri.ID = entity.ID;
			musteri.MusteriAd = entity.MusteriAd;
			return dao.Update(musteri);
		}
	}
}
