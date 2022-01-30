using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOgrenciBilgiService
    {
        void OgrenciBilgiAdd(OgrenciBilgi ogrenciBilgi);
        void OgrenciBilgiDelete(OgrenciBilgi ogrenciBilgi);
        void OgrenciBilgiUpdate(OgrenciBilgi ogrenciBilgi);
        List<OgrenciBilgi> GetList();
        OgrenciBilgi GetById(int id);
    }
}
