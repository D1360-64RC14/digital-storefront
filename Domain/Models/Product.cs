using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Enums;

namespace Domain.Models;

public class Product
{
    public required Guid Id { get; set; }
    public required string Gtin { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required Uri Image { get; set; }
    public required decimal Price { get; set; }
    public required ProductStatus Status { get; set; }
}
