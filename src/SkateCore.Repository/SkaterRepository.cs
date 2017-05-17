using SkateCore.Repository.Interfaces;
using System;
using SkateCore.Domain;
using System.Collections.Generic;
using SkateCore.Data.Entity;

namespace SkateCore.Repository
{
    public class SkaterRepository : ISkaterRepository
    {
        private readonly SkateCoreContext context;

        public SkaterRepository(SkateCoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<Skater> Get()
        {
            return context.Skaters;
        }
    }
}
