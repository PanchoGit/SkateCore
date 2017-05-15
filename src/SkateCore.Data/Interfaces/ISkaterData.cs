using SkateCore.Domain;
using System.Collections.Generic;

namespace SkateCore.Data.Interfaces
{
    public interface ISkaterData
    {
        IList<Skater> Get();
    }
}
