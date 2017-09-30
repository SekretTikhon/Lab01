using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Programmer : Person, IDeepCopy
    {
        protected List<Subject> listSubject;
        public Programmer(Person p, params Subject[] subjects) : base(p.FirstName, p.LastName, p.Date)
        {
            listSubject = new List<Subject>();
            AddSubjects(subjects);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Subject sbj in listSubject)
            {
                str.Append("    " + sbj + "\n");
            }
            return (base.ToString() + "  subjects:\n" + str);
        }
        public override string ToShortString()
        {
            return (base.ToShortString() + "  count subjects: " + listSubject.Count + "\n");
        }
        public void AddSubjects(params Subject[] subjects)
        {
            foreach (Subject sub in subjects)
            {
                listSubject.Add(sub);
            }
        }
        public void RemoveSubjectAt(int index)
        {
            listSubject.RemoveAt(index);
        }
        public override object DeepCopy()
        {
            Programmer pro = new Programmer((Person)base.DeepCopy(), new Subject[] { });
            foreach (Subject sub in listSubject)
            {
                pro.listSubject.Add(sub);
                //pro.AddSubjects(sub);
            }
            return pro;
        }
    }
}
