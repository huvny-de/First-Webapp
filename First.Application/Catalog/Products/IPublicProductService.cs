using First.Application.Catalog.Dtos;
using First.Application.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}
