using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Department : IDeepCopy, IEnumerable<Person>
    {
        protected List<Person> listPerson;//= new List<Person>();
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Department()
        {
            Name = "Hogwarts";
            Date = new DateTime(1901, 9, 1);
            listPerson = new List<Person>();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Person per in listPerson)
            {
                str.Append(per.ToString());
            }
            return (Name + "\n  date of foundation: " + Date.ToString("d") + "\n  persons:\n" + str);
        }
        public string ToShortString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Person per in listPerson)
            {
                str.Append((per is Researcher ? "Researcher " : "") + (per is Programmer ? "Programmer " : "") + per.ToShortString());
            }
            return str.ToString();
        }
        public void AddPersons(params Person[] person)
        {
            foreach (Person per in person)
            {
                listPerson.Add(per);
            }
        }
        public void AddDefaults()
        {
            listPerson.Add(new Researcher(new Person("Hermione", "Granger", 19, 9, 1979), 7, new Paper[] { new Paper("rare magic plants", 2, Subject.plants), new Paper("patronus and their abilities", 1, Subject.spells) }));
            listPerson.Add(new Programmer(new Person("Harry", "Potter", 31, 7, 1980), new Subject[] { Subject.attack, Subject.defense }));
            listPerson.Add(new Researcher(new Person("Ginny", "Weasley", 11, 8, 1981), 4, new Paper[] { new Paper("rare magic plants", 2, Subject.plants), new Paper("mandrake root", 1, Subject.plants) }));
            listPerson.Add(new Programmer(new Person("Ronald", "Weasley", 1, 3, 1980), new Subject[] { Subject.cats}));
        }
        public object DeepCopy()
        {
            Department dep = new Department();
            dep.Name = this.Name;
            dep.Date = this.Date;
            //dep.listPerson = new List<Person>();
            foreach (Person per in this.listPerson)
            {
                
                if (per is Researcher)
                    dep.listPerson.Add(per.DeepCopy() as Researcher);
                else if (per is Programmer)
                    dep.listPerson.Add(per.DeepCopy() as Programmer);
                else
                    dep.listPerson.Add(per.DeepCopy() as Person);
                //dep.listPerson.Add((Person)per.DeepCopy());
            }
            return dep;
        }
        public Person this[int index]
        {
            get { return listPerson[index]; }
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return ((IEnumerable<Person>)listPerson).GetEnumerator();
        }
        /*
        public IEnumerator ResIterator()/////////
        {
            foreach (Person per in listPerson)
            {
                if (per is Researcher)
                    yield return per;
            }
        }
        */
        //что за херня!!!!
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Person>)listPerson).GetEnumerator();
        }

    }
}
