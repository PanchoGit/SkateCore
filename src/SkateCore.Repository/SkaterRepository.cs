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

        public Skater Create(Skater skater)
        {
            var result = set.Add(skater);

            context.SaveChanges();

            return result.Entity;
        }

        public IEnumerable<Skater> Get()
        {
            return set.ToListAsync().Result;
        }
    }
}
