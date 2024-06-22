using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Combination
{
    public required Guid Id { get; set; }
    public required Uri Image { get; set; }
    public required decimal Price { get; set; }
}
