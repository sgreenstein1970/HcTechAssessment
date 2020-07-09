using System.Collections.Generic;

namespace HcTechAssessment
{
    public interface IMemberRepository
    {
        List<Member> GetAllMembers();
        List<Member> GetMembersByName(string searchString);
    }
}