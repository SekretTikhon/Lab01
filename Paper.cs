using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Paper : IDeepCopy
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public Subject Sub { get; set; }
        public Paper(string name = "Game of Thrones", int amount = 1, Subject sub = Subject.fantasy)
        {
            Name = name;
            Amount = amount;
            Sub = sub;
        }
        public override string ToString()
        {
            return (Name + ", subject: " + Sub + ", authors: " + Amount + "\n");
        }
        public object DeepCopy()
        {
            return new Paper(this.Name, this.Amount, this.Sub);
        }
    }
    enum Subject
    {
        fantasy, defense, attack, plants, spells, kekeke, meow, cats
    }
}
