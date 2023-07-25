using Faker;
using GoodsCatalog.Database;
using GoodsCatalog.Models;

namespace GoodsCatalog
{
    public class ConsoleWorker
    {
        public static void MakeRecords(int numRecords)
        {
            List<Good> goods = new();
            CatalogContext context = new();

            for (int fakeRecord = 0; fakeRecord < numRecords; fakeRecord++)
            {
                Good good = new();
                good.GoodName = Faker.Name.Last();
                good.Price = Faker.RandomNumber.Next(1000000);
                good.GoodsTypeId = Faker.RandomNumber.Next(context.GoodsTypes.Count() - 1);
                good.GoodsType = context.GoodsTypes.ToList()[good.GoodsTypeId];
                good.GoodsManufactureId = Faker.RandomNumber.Next(context.GoodsManufactures.Count() - 1);
                good.GoodsManufacture = context.GoodsManufactures.ToList()[good.GoodsManufactureId];

                goods.Add(good);
            }

            context.Goods.AddRange(goods);
            context.SaveChanges();

        }
    }

    //class Program 
    //{ 
    //    static void Main(string[] args) 
    //    {
    //        Console.WriteLine("Введите число записей");
    //        int numRecords = Convert.ToInt32(Console.ReadLine());
    //        ConsoleWorker.MakeRecords(numRecords);
    //    } 
    //}
    
}
