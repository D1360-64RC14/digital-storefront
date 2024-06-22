using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface ICartPersistence
{
    List<Product> FindCartFor(Customer customer);
    void AddProductToCart(Product product, Customer customer);
    void RemoveProductFromCart(Product product, Customer customer);
    Guid StoreCart(Customer customer);
}
