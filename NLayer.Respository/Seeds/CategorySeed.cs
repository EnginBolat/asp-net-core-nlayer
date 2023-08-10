using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Respository.Seeds
{
    internal interface CategorySeed : IEntityTypeConfiguration<Category>
    {
        void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category { Id = 1, Name = "Kalemler" },
            new Category { Id = 2, Name = "Kitaplar" },
            new Category { Id = 3, Name = "Defterler" });
        }
    }
    
}

