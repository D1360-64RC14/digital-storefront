using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports.Driven.Persistence;

public interface ICategoryPersistence
{
    List<Category> FetchCategories();
    Category? FetchCategoryBy(Guid id);

    void Store(out Category category);
    void Update(out Category category);
    void Remove(Category category);
}
