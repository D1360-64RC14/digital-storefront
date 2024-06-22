using Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class Cart
{
    public required Guid Id { get; set; }
    public required CartStatus Status { get; set; }
}
