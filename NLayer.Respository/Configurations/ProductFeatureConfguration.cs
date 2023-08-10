using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using NLayer.Core.Model;

namespace NLayer.Respository.Configurations
{
	public interface ProductFeatureConfguration : IEntityTypeConfiguration<ProductFeature>
    {
        void IEntityTypeConfiguration<ProductFeature>.Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);

        }
    }
}

