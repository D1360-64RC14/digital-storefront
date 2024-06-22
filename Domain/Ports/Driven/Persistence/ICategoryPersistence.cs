using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface ICategoryPersistence
{
    List<Category> FetchAllCategories();
    Category? FetchCategoryById(Guid id);
}
