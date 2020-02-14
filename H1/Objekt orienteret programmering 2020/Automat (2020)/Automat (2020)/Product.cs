using System;
using System.Collections.Generic;
using System.Text;

namespace Automat__2020_
{
    class Product
    {
        private string productName;
        private int productPrice;

        public string ProductName
        {
            get { return productName; }
            set { this.productName = value; }
        }

        public int ProductPrice
        {
            get { return productPrice; }
            set { this.productPrice = value; }
        }



        public Product(string Name, int Price)
        {

        }
    }
}
