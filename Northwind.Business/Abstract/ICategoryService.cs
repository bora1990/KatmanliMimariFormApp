using Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
