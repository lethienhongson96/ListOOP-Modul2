using System;
using System.Collections.Generic;
using System.Text;

namespace Product_ListArray
{
    class Product_Demo : IComparable<Product_Demo>, IFormattable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Origin { get; set; }

        public Product_Demo()
        {

        }

        public Product_Demo(int id,string name,double price,string origin)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Origin = origin;
        }

        public int CompareTo(Product_Demo other)
        {
            double result = this.Price - other.Price;
            if (result > 0)
            {
                return 1;
            }

            else if (result < 0)
            {
                return -1;
            }
            return 0;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format==null)
            {
                format = "origin";
            }
            switch (format.ToUpper())
            {
                case "ORIGIN":
                    return $"origin={this.Origin} name={this.Name} price={this.Price} ID={this.ID}";
                case "NAME":
                    return $"name={this.Name} origin={this.Origin} price={this.Price} ID={this.ID}";
                default:
                    throw new FormatException("not allow");
            }
        }

        public override string ToString() => $"{this.Name}--{this.Price}";

        public string ToString(string format) => this.ToString(format,null);

        
    }
}
