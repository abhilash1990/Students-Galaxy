﻿using Students_Galaxy_Infrastructure.Contexts;
using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_Infrastructure.Repositories
{
    class ProductRepository : GenericRepository<ProductMaster>, IProductRepository
    {
        public ProductRepository(InventoryManagementContext context) : base(context)
        {

        }
    }
}
