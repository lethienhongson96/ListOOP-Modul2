using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ForumRate
{
    class Forum
    {
        /// <summary>
        /// more 1 value for id
        /// posts for management
        /// </summary>
        public static int moreId=0;
        public SortedList<int,Post> Posts = new SortedList<int, Post>();

        #region service
        public void Add()
        {
            moreId++;
            Console.WriteLine("enter title");
            string title = Console.ReadLine();

            Console.WriteLine("enter content");
            string content = Console.ReadLine();

            Console.WriteLine("enter author");
            string author = Console.ReadLine();

            Post post = new Post(title, content, author);
            post.ID = moreId;
            Posts.Add(post.ID,post);
        }

        public void Update(int idKey)
        {
            if (Posts.ContainsKey(idKey))
            {
                Console.WriteLine("enter new content");
                Posts[idKey].Content = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("not found");
            }
        }

        public void Delete(int idKey)
        {
            if (Posts.ContainsKey(idKey))
            {
                Posts.Remove(idKey);
                Console.WriteLine("complete");
            }

            else
            {
                Console.WriteLine($"not found {idKey}");
            }
        }

        public void Show()
        {
            ICollection key = (ICollection)Posts.Keys;

            foreach (int k in key)
            {
                Console.WriteLine(Posts[k].Display());
            }
        }

        public void SearchByAuthor(string author)
        {
            int keyByAuthor = -1;
            ICollection key = (ICollection)Posts.Keys;

            foreach (int k in key)
            {
                if (Posts[k].Author== author)
                {
                    keyByAuthor = k;
                    break;
                }
            }
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(Posts[keyByAuthor].Display());
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public void SearchByTitle(string title)
        {
            int keyByTitle = -1;
            foreach (var key in Posts.Keys)
            {
                if (Posts[key].Title==title)
                {
                    keyByTitle = key;
                    break;
                }
            }
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(Posts[keyByTitle].Display());
            Console.WriteLine("-------------------------------------------------------------------");
        }
        #endregion

        #region Set Number for input
        public int MustNumber()
        {
            bool isNumeric;
            int n;
            do
            {
                isNumeric = int.TryParse(Console.ReadLine(), out n);
                if (!isNumeric)
                    Console.WriteLine("not allow");
            } while (isNumeric == false);
            return n;
        }

        public int SetValueRate()
        {
            bool isInterger;
            int n;

            do
            {
                isInterger = int.TryParse(Console.ReadLine(), out n);
                if (!isInterger || n < 1 || n > 5)
                {
                    Console.WriteLine("not allow!!!/ bettwen 1 to 5:");
                    isInterger = false;
                }

            } while (isInterger == false);

            return n;
        }
        #endregion

        #region Rating for Post
        public void Rating(int idKey)
        {
            if (Posts.ContainsKey(idKey))
            {
                Console.WriteLine("enter the rate for this post");
                int rateValue = SetValueRate();

                Array.Resize(ref Posts[idKey].Rates, Posts[idKey].Rates.Length + 1);
                Posts[idKey].Rates[Posts[idKey].Rates.Length - 1] = rateValue;

                Posts[idKey].CalculatorRate();
            }

            else
            {
                Console.WriteLine("not found id");
            }
        }
        #endregion
    }
}
