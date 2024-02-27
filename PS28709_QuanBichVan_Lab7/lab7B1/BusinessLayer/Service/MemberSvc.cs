using DataLayer.Context;
using DataLayer.Repository;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using DataLayer.IRepository;

namespace BusinessLayer.Service
{
    public class MemberSvc : IMemberSvc
    {
        private readonly MemberSvc memberRepository;

        public MemberSvc(MemberSvc memberRepository)
        {
            this.memberRepository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
        }
         
        public List<Member> GetList()
        {
            return memberRepository.GetList();
        }

        public bool Add(Member member)
        {
            return memberRepository.Add(member);
        }

        public bool Update(Member member)
        {
            return memberRepository.Update(member);
        }

        public bool Delete(Member member)
        {
            return memberRepository.Delete(member);
        }

        public bool Save()
        {
            return memberRepository.Save();
        }
    }
}
