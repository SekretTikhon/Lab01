using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p1 = new Person("Ginny", "Weasley", 11, 8, 1981);
            Person p2 = (Person)p1.DeepCopy();
            p2.FirstName = "Harry";
            p2.LastName = "Potter";
            p2.Date = new DateTime(1980, 8, 31);
            Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);
            */
            /*
            StringBuilder str = new StringBuilder();
            str.Append("Hello, ");
            str.Append("World!");
            Console.WriteLine(str);
            */
            /*
            Researcher r1 = new Researcher(new Person("Ginny", "Weasley", 11, 8, 1981), 3, new Paper[] { new Paper("keeee", 1, Subject.kekeke), new Paper("lyal", 3, Subject.meow) });
            Researcher r2 = (Researcher)r1.DeepCopy();
            r2.FirstName = "Harry";
            r2.LastName = "Potter";
            r2.Date = new DateTime(1980, 7, 31);
            r2.RemovePaperAt(0);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            */
            /*
            Programmer pr1 = new Programmer(new Person("Ginny", "Weasley", 11, 8, 1981), new Subject[] { Subject.cats, Subject.def });
            Programmer pr2 = (Programmer)pr1.DeepCopy();
            pr2.FirstName = "Harry";
            pr2.LastName = "Potter";
            pr2.Date = new DateTime(1980, 8, 31);
            pr2.RemoveSubjectAt(0);
            Console.WriteLine(pr1);
            Console.WriteLine(pr2);
            */
            /*
            Department dp1 = new Department();
            dp1.AddDefaults();
            Department dp2 = (Department)dp1.DeepCopy();
            Console.WriteLine(dp1);
            Console.WriteLine(dp2);
            */

            Department dep1 = new Department();
            dep1.AddDefaults();
            Console.WriteLine(dep1.ToString());
            Console.WriteLine(dep1.ToShortString());
            foreach (Person per in dep1)
            {
                Console.Write(per);
            }
            Console.WriteLine("meow");
            /*
            foreach (Person per in dep1.ResIterator())
            {
            }
            */

            Console.ReadKey();

        }
    }
}
