using System;
using System.Collections.Generic;

namespace StudentManagement_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("hongson",123,"27/11/96","VN","C05",2073));
            students.Add(new Student("tan",456,"11/8/97","USA","C0510",2074));
            students.Add(new Student("vui",789,"12/113/20","lao","C05g1",2075));
            students.Add(new Student("tung",147,"27/11/94","TQ","C0510g1",2076));

            students.Sort();
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }

            var foundresult = students.Find(
                    item=>item.ID==456
                );
            Console.WriteLine(foundresult.ToString());

            students.Sort(
                (item1,item2)=>
                {
                    if (item1.PhoneNum > item2.PhoneNum)
                        return 1;
                    else if (item1.PhoneNum < item2.PhoneNum)
                        return -1;
                    return 0;
                }
            );

            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("-------------------");
            bool checkOB = students.Contains(new Student {ID = 789 });
            Console.WriteLine(checkOB);
        }
    }
}
