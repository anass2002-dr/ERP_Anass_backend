﻿using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.FamilyRepo
{
    public class FamillyRepo : IFamillyRepo
    {
        private readonly DbContextERP _context;

        public FamillyRepo(DbContextERP context)
        {
            _context = context;
        }

        public Familly AddFamilly(Familly familly)
        {
            _context.Familly.Add(familly);
            _context.SaveChanges();
            return familly;
        }

        public bool DeleteFamilly(int id)
        {
            var familly = _context.Familly.Find(id);
            if (familly == null)
            {
                return false;
            }

            _context.Familly.Remove(familly);
            _context.SaveChanges();
            return true;
        }

        public Familly GetFamilyById(int id)
        {
            return _context.Familly.Find(id);
        }

    
      

        public List<Familly> GetFamillys()
        {
            return _context.Familly.ToList();
        }

        public Familly UpdateFamilly(Familly familly)
        {
            _context.Familly.Update(familly);
            _context.SaveChanges();
            return familly;
        }
    }
}
