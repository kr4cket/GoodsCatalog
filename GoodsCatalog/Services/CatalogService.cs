using GoodsCatalog.Database;
using GoodsCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsCatalog.Services
{
    public class CatalogService
    {
        private CatalogContext dataBase = new();
        public List<Good> GetCatalogData(int page)
        {
            return dataBase.Goods.Include(manufacture => manufacture.GoodsManufacture).ToList();
        }
    }
}
