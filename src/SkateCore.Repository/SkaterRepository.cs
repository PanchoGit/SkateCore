using SkateCore.Repository.Interfaces;
using SkateCore.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SkateCore.Repository
{
    public class SkaterRepository : RepositoryBase<Skater, int>, ISkaterRepository
    {
        public SkaterRepository(SkateCoreContext context) : base(context)
        {
        }

        public IEnumerable<Skater> Get()
        {
            return set.ToListAsync().Result;
        }
    }
}
