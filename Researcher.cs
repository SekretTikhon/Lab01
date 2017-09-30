using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Researcher : Person, IDeepCopy
    {
        public double Exp { get; set; }
        protected List<Paper> listPaper;
        public Researcher(Person p, double exp, params Paper[] papers) : base(p.FirstName, p.LastName, p.Date)
        {
            Exp = exp;
            listPaper = new List<Paper>();
            AddPapers(papers);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Paper pap in listPaper)
            {
                str.Append("    " + pap);
            }
            return (base.ToString() + "  exp: " + Exp + "\n  research:\n" + str);
        }
        public override string ToShortString()
        {
            return (base.ToShortString() + "  exp: " + Exp + "\n  count research: " + listPaper.Count + "\n");
        }
        public void AddPapers(params Paper[] papers)
        {
            foreach (Paper pap in papers)
            {
                listPaper.Add(pap);
            }
        }
        public void RemovePaperAt(int index)
        {
            listPaper.RemoveAt(index);//hz
        }
        public override object DeepCopy()
        {
            Researcher res = new Researcher((Person)base.DeepCopy(), this.Exp, new Paper[] { });
            foreach (Paper pap in listPaper)
            {
                res.listPaper.Add((Paper)pap.DeepCopy());
                //res.AddPapers((Paper)pap.DeepCopy());
            }
            return res;
        }
    }
}
