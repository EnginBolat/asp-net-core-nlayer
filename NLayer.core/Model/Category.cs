using NLayer.Core.Model;
using System;
namespace NLayer.Core
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

