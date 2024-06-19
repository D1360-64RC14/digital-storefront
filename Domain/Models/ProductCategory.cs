using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class ProductCategory
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
}
