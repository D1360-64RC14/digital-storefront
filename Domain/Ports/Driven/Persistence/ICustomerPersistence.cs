using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface ICustomerPersistence
{
    Customer? FindCustomerBy(Guid id);

    void Store(out Customer customer);
    void Update(out Customer customer);
    void Inactivate(out Customer customer);
    void Block(out Customer customer);
}
