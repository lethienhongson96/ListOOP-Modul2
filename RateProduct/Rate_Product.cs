using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RateProduct
{
    class Rate_Product : IComparable<Rate_Product>
    {
        public string Name { get; set; }
        public string Desciption { get; set; }
        public double Price { get; set; }
        public double AvgRate { get; set; }

        public int[] RateList = new int[3];

        public override string ToString()
        {
            return $"name={Name} price={this.Price} descrip={this.Desciption} AvgRate={this.AvgRate}";
        }

        public void SetAvg()
        {
            double sum = 0;
            for (int i=0;i<this.RateList.Length;i++)
            {
                sum += RateList[i];
            }
            this.AvgRate = sum / this.RateList.Length;
        }

        public int CompareTo([AllowNull] Rate_Product other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}
