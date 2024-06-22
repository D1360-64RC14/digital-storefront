using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface IVariantPersistence
{
    List<Variant> FetchVariants();
    List<VariantItem> FetchItemsFrom(Variant variant);
    Variant? FetchVariantBy(Guid id);

    void Store(out Variant variant);
    void Store(out VariantItem variantItem);
    void Update(out Variant variant);
    void Remove(VariantItem variantItem);
    void Remove(Variant variant);
}
