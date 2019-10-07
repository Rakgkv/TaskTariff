using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTariff.Model
{
    public class ProductModel
    {
        public string name { get; set; }
        public double annualTariff { get; set; }
    }
}
