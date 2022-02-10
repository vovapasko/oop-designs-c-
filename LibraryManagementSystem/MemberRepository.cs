using System.Collections.Generic;

namespace OopDesigns.LibraryManagementSystem
{
    public class MemberRepository : IRepository<Member, string>
    {
        public Member Create(Member toCreate)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Member toDelete)
        {
            throw new System.NotImplementedException();
        }

        public Member Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Member Update(Member toUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}