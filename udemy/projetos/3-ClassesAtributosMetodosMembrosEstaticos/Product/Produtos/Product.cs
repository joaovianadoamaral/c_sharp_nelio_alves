using System;
using System.Collections.Generic;
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

        public void AddQuantityProducts(int Quantity)
        {
            Amount += Quantity;

        }

        public void RemoveQuantityProducts(int Quantity)
        {
            Amount -= Quantity;
        }


    }
}
