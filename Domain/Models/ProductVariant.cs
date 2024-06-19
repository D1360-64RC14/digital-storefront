﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models;

public class ProductVariant
{
    public required Guid Id { get; set; }
    public required string Label { get; set; }
}