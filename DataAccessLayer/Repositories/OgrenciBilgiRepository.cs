using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OgrenciBilgiRepository : IOgrenciBilgiDAL
    {
        public void AddOgrenciBilgi(OgrenciBilgi ogrenciBilgi)
        {
            using var c = new Context();
            c.Add(ogrenciBilgi);
            c.SaveChanges();
        }

        public void Delete(OgrenciBilgi t)
        {
            throw new NotImplementedException();
        }

        public void DeleteOgrenciBilgi(OgrenciBilgi ogrenciBilgi)
        {
            using var c = new Context();
            c.Remove(ogrenciBilgi);
            c.SaveChanges();
        }

        public OgrenciBilgi GetById(int id)
        {
            using var c = new Context();
            return c.OgrenciBilgies.Find(id);
        }

        public OgrenciBilgi GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciBilgi> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(OgrenciBilgi t)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciBilgi> ListAllOgrenciBilgi()
        {
            using var c = new Context();
            return c.OgrenciBilgies.ToList();


        }

        public void Update(OgrenciBilgi t)
        {
            throw new NotImplementedException();
        }

        public void UpdateOgrenciBilgi(OgrenciBilgi ogrenciBilgi)
        {
            using var c = new Context();
            c.Update(ogrenciBilgi);
            c.SaveChanges();
        }
    }
}
