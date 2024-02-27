using DataLayer.Context;
using DataLayer.IRepository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
    public class MemberSvc : IMemberSvc
    {
        private readonly ContactDbContext db;

        public MemberSvc(ContactDbContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public List<Member> GetList()
        {
            return db.Members.ToList();
        }

        public bool Add(Member member)
        {
            try
            {
                db.Members.Add(member);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Member member)
        {
            var existingMember = db.Members.FirstOrDefault(m => m.Id == member.Id);
            if (existingMember == null)
                return false;

            try
            {
                existingMember.Name = member.Name;
                existingMember.Phone = member.Phone;
                existingMember.Email = member.Email;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Member member)
        {
            var existingMember = db.Members.FirstOrDefault(m => m.Id == member.Id);
            if (existingMember == null)
                return false;

            try
            {
                db.Members.Remove(existingMember);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
