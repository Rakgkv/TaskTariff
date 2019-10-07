using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TaskTariff.DataAccess;
using TaskTariff.Service;
using static TaskTariff.DataAccess.ProductDataAccess;

namespace TaskTariff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariffController : ControllerBase

    {
        // GET api/tariff
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/tariff/5000
        [HttpGet("{consumption}")]
        public ActionResult<IEnumerable<string>> Get(int consumption)
   
        {
            // setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITariffService, TariffService>()
                .BuildServiceProvider();

            var tariffService = serviceProvider.GetService<ITariffService>();
             string[] sortOrderList = new String[2];
            using (IEnumerator<IProduct> productEnumerator = tariffService.GetProducts(consumption).GetEnumerator())
            {

                string[] sortOrder = new String[2];
              
                int i = 0;
                while (productEnumerator.MoveNext())
                {
                    IProduct product = productEnumerator.Current;
                    sortOrder[i] = (i+1) + ". " + product.Name + " : " + product.AnnualTariff + " Euros";

                    i++;
                }
                sortOrderList = sortOrder;
            }

            return sortOrderList;
            

        }

        // POST api/tariff
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/tariff/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/tariff/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
