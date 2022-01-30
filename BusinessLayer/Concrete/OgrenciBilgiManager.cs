using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OgrenciBilgiManager : IOgrenciBilgiService
    {

        EfOgrenciBilgiRepository efOgrenciBilgiRepository;
        public OgrenciBilgiManager()
        {
            efOgrenciBilgiRepository = new EfOgrenciBilgiRepository();
        }
        public OgrenciBilgi GetById(int id)
        {
            return efOgrenciBilgiRepository.GetByID(id);
        }

        public List<OgrenciBilgi> GetList()
        {
            return efOgrenciBilgiRepository.GetList() ;
        }

        public void OgrenciBilgiAdd(OgrenciBilgi ogrenciBilgi)
        {
            efOgrenciBilgiRepository.Insert(ogrenciBilgi);
        }

        public void OgrenciBilgiDelete(OgrenciBilgi ogrenciBilgi)
        {
            efOgrenciBilgiRepository.Delete(ogrenciBilgi);
        }

        public void OgrenciBilgiUpdate(OgrenciBilgi ogrenciBilgi)
        {
            efOgrenciBilgiRepository.Update(ogrenciBilgi);
        }
    }
}
