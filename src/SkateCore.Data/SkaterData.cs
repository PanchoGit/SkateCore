using System;
using System.Collections.Generic;
using SkateCore.Data.Interfaces;
using SkateCore.Domain;

namespace SkateCore.Data
{
    public class SkaterData : ISkaterData
    {
        public IList<Skater> Get()
        {
            var skater = new Skater()
            {
                Name = "Luan"
            };
            return new List<Skater> { skater };
        }
    }
}
