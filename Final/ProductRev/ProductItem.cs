//K1773

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductRev

{
    public class ProductItem
    {
        private int _quantity;
        private double _price;


        public string Description
        {
            get; set;

        }

        public string ProductNumber
        {
            get; set;

        }

        public int Quantity
        {
            get 
            {
                return _quantity;
            }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else 
                {
                    _quantity = 0;
                }
            }

        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0.0;
                }
            }

        }

        public ProductItem(string desc, string productNum, int quant, double price)
        {
            Description = desc;
            ProductNumber = productNum;
            Quantity = quant;
            Price = price;

        }

        public double CalcValue()
        {
            return (Price * Quantity);

        }

        public override string ToString()
        {
            return ProductNumber + ": " + Description + " " + "(" + Quantity + " @ " + Price.ToString("C2", CultureInfo.CurrentCulture) + ")";
        }
    }
}
