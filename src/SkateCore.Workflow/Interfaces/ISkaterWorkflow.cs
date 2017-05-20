using SkateCore.Domain;
using System.Collections.Generic;

namespace SkateCore.Workflow.Interfaces
{
    public interface ISkaterWorkflow
    {
        IEnumerable<Skater> Get();

        Skater Post(Skater skater);
    }
}