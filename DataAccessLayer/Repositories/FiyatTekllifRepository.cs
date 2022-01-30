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
    class FiyatTekllifRepository : IFiyatDAL
    {
        Context c = new Context();
        public void AddOFiyatTeklif(FiyatTeklif fiyatTeklif)
        {
            c.Add(fiyatTeklif);
            c.SaveChanges();
        }

        public void Delete(FiyatTeklif t)
        {
            throw new NotImplementedException();
        }

        public void DeleteFiyatTeklif(FiyatTeklif fiyatTeklif)
        {
            c.Remove(fiyatTeklif);
            c.SaveChanges();
        }

        public FiyatTeklif GetById(int id)
        {
            return c.FiyatTeklifs.Find(id);
        }

        public FiyatTeklif GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<FiyatTeklif> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(FiyatTeklif t)
        {
            throw new NotImplementedException();
        }

        public List<FiyatTeklif> ListAllFiyatTeklif()
        {
            return c.FiyatTeklifs.ToList();
        }

        public void Update(FiyatTeklif t)
        {
            throw new NotImplementedException();
        }

        public void UpdateFiyatTeklif(FiyatTeklif fiyatTeklif)
        {
            c.Update(fiyatTeklif);
            c.SaveChanges();         
        }
    }
}
