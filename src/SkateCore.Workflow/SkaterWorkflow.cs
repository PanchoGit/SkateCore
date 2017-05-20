using SkateCore.Workflow.Interfaces;
using SkateCore.Domain;
using System.Collections.Generic;
using SkateCore.Repository.Interfaces;

namespace SkateCore.Workflow
{
    public class SkaterWorkflow : ISkaterWorkflow
    {
        private readonly ISkaterRepository repository;

        public SkaterWorkflow(ISkaterRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Skater> Get()
        {
            return repository.Get();
        }

        public Skater Post(Skater skater)
        {
            return repository.Create(skater);
        }
    }
}
