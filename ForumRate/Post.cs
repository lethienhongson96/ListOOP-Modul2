using System;
using System.Collections.Generic;
using System.Text;

namespace ForumRate
{
    class Post : IPost
    {
        #region properties in Post class
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }

        public int[] Rates = new int[0];
        #endregion

        #region constructor
        public Post()
        {

        }
        public Post(string title,string content,string author)
        {
            this.Title=title;
            this.Content = content;
            this.Author = author;
        }
        #endregion

        #region eplement iterface from IPost
        public void CalculatorRate()
        {
            float sum = 0;
            for (int i = 0; i < this.Rates.Length; i++)
            {
                sum += Rates[i];
            }
            this.AverageRate = sum / this.Rates.Length;
        }

        public string Display()
        {
            return $"id={this.ID} title={this.Title} content={this.Content} author={this.Author}" +
                $" count rate={this.Rates.Length} rate={this.AverageRate}";
        }
        #endregion
    }
}
