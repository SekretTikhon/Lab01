using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Person : IDeepCopy
    {
        protected string[] name;//= new string[2];
        protected DateTime date;
        public string FirstName
        {
            get { return name[0]; }
            set { name[0] = value; }
        }
        public string LastName
        {
            get { return name[1]; }
            set { name[1] = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Person(string first_name = "Garry", string last_name = "Potter", int d = 31, int m = 7, int y = 1980)
        {
            this.name = new string[2];
            FirstName = first_name;
            LastName = last_name;
            this.date = new DateTime(y, m, d);
        }
        public Person(string first_name, string last_name, DateTime date/* = new DateTime(1980, 7, 31)*/)
        {
            this.name = new string[2];
            FirstName = first_name;
            LastName = last_name;
            this.date = new DateTime();
            Date = date;
        }
        public override string ToString()
        {
            return (FirstName + " " + LastName + "\n  date: " + Date.ToString("d") + "\n");
        }
        public virtual string ToShortString()
        {
            return (FirstName + " " + LastName + "\n");
        }
        public virtual object DeepCopy()
        {
            return new Person(this.FirstName, this.LastName, this.Date);
        }
    }
}
