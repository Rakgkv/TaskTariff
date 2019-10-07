using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTariff.DataAccess;
using static TaskTariff.DataAccess.ProductDataAccess;

namespace TaskTariff.Service
{
    public interface ITariffService
    {
        IEnumerable<IProduct> GetProducts(int usage);
    }

    public class TariffService : ITariffService
    {
        public IEnumerable<IProduct> GetProducts(int usage)
        {
            List<IProduct> products = new List<IProduct>();

            products.Add(new ProductA().CalculateTariff(usage));
            products.Add(new ProductB().CalculateTariff(usage));

            products.Sort((x, y) => x.AnnualTariff.CompareTo(y.AnnualTariff));

            return products;
        }
    }
}
