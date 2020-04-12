using CFPP.Database.Context;
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;

namespace CFPP.Database.Repositories
{
    public class CaseRepository : Repository<Case>, ICaseRepository
    {
        public CaseRepository(CFPPDbContext context)
            : base(context)
        {
        }
    }
}
