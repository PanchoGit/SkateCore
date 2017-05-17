using SkateCore.Domain;
using System.Collections.Generic;

namespace SkateCore.Repository.Interfaces
{
    public interface ISkaterRepository
    {
        IEnumerable<Skater> Get();
    }
}
