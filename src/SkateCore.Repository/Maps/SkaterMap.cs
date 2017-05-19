using SkateCore.Domain;
using EntityFrameworkCore.MappingExtension;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SkateCore.Repository.Maps
{
    public class SkaterMap : ModelTypeConfiguration<Skater>
    {
        public override void Map(EntityTypeBuilder<Skater> builder)
        {
        }
    }
}
