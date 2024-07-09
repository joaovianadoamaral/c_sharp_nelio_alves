using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Amount;
        public double TotalValueInStock()
        {
            double TotalValue;
            TotalValue = Price * Amount;

            return TotalValue;
        }

        public void AddQuantityProducts(int quantity)
        {
            Amount += quantity;

        }

        public void RemoveQuantityProducts(int quantity)
        {
            Amount -= quantity;
        }

        public override string ToString()
        {
            string text;
            double TotalValue = TotalValueInStock();

            text = $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, ";
            text += $"{Amount} unidades, ";
            text += $"Total: $ {TotalValue.ToString("F2", CultureInfo.InvariantCulture)}";


            return text;
        }
    }
}
