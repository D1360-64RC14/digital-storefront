using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface ICartPersistence
{
    Cart FetchCartFor(Customer customer);
    Cart StoreCartFrom(Customer customer);

    void AddToCart(Product product, Customer customer);
    void RemoveFromCart(Product product, Customer customer);
    void ClearCartFrom(Customer customer);
}
