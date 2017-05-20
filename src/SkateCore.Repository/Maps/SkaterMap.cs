using SkateCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkateCore.Repository.Configurations;

namespace SkateCore.Repository.Maps
{
    public class SkaterMap : EntityMappingConfiguration<Skater>
    {
        public override void Map(EntityTypeBuilder<Skater> builder)
        {
        }
    }
}
