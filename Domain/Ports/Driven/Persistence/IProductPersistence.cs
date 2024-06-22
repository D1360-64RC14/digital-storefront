using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface IProductPersistence
{
    List<Product> FetchProducts();
    List<Combination> FetchCombinationsFor(Product product);
    Product? FetchProductBy(Guid id);

    void Store(out Product product);
    void Update(out Product product);
    void Remove(Product product);
    void Hide(Product product);
}
