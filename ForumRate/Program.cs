using System;

namespace ForumRate
{
    class Program
    {
        public static Forum forumList = new Forum();
        static void Main(string[] args)
        {
            do
            {
                Menu();
                int checkPress = Convert.ToInt32(Console.ReadLine());

                if (checkPress==7)
                {
                    break;
                }
                ChooseMenu(checkPress);

            } while(true);
        }

        public static void Menu()
        {
            Console.WriteLine("1/Create Post");
            Console.WriteLine("2/Update Post");
            Console.WriteLine("3/Remove Post");
            Console.WriteLine("4/Show Posts");
            Console.WriteLine("5/Search Post");
            Console.WriteLine("6/Rating Post");
            Console.WriteLine("7/exit");
        }

        public static void ChooseMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    forumList.Add();
                    break;

                case 2:
                    Console.WriteLine("enter id to update: ");
                    int idkeyUpdate = forumList.MustNumber();
                    forumList.Update(idkeyUpdate);
                    break;

                case 3:
                    Console.WriteLine("enter id to delete: ");
                    int idkeyDel = forumList.MustNumber();
                    forumList.Delete(idkeyDel);
                    break;

                case 4:
                    Console.WriteLine("---------------------------------------------------------------------");
                    forumList.Show();
                    Console.WriteLine("---------------------------------------------------------------------");
                    break;

                case 5:
                    if (CheckTypeSearch())
                    {
                        Console.WriteLine("enter author to search:");
                        forumList.SearchByAuthor(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("enter title to search: ");
                        forumList.SearchByTitle(Console.ReadLine());
                    }
                    break;

                case 6:
                    Console.WriteLine("enter id of post to rate: ");
                    int idKeyRate=forumList.MustNumber();
                    forumList.Rating(idKeyRate);
                    break;
            }
        }

        public static bool CheckTypeSearch()
        {
            do
            {
                Console.WriteLine("press 1 to search by author/ 2 by title");
                int check = forumList.MustNumber();

                if (check == 1)
                {
                    return true;
                }

                else if (check == 2)
                {
                    return false;
                }
            } while (true);
        } 
    }
}
