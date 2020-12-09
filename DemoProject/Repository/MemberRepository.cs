using DemoProject.Contracts;
using DemoProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ApplicationDbContext _db;

        public MemberRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Member entity)
        {
            _db.Members.Add(entity);
            return Save();
        }

        public bool Delete(Member entity)
        {
            _db.Members.Remove(entity);
            return Save();
        }

        public ICollection<Member> FindAll()
        {
            return _db.Members.ToList();
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Member entity)
        {
            _db.Members.Update(entity);
            return Save();
        }
    }
}
