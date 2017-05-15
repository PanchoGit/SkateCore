using SkateCore.Workflow.Interfaces;
using SkateCore.Domain;
using System.Collections.Generic;
using SkateCore.Data.Interfaces;

namespace SkateCore.Workflow
{
    public class SkaterWorkflow : ISkaterWorkflow
    {
        private readonly ISkaterData data;

        public SkaterWorkflow(ISkaterData data)
        {
            this.data = data;
        }

        public IList<Skater> Get()
        {
            return data.Get();
        }
    }
}
