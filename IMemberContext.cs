using System;
using Microsoft.EntityFrameworkCore;

namespace HcTechAssessment
{
    public interface IMemberContext: IDisposable
    {
        DbSet<Member> Members { get; set; }

        
    }
}