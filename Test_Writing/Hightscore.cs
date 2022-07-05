using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Writing
{
    internal class Hightscore : IComparable<Hightscore>
    {

        public string Name { get; set; }
        public int Score { get; set; }

        public Hightscore (string name, int score)
            {
            this.Name = name;
            this.Score = score;
            }

        public override string ToString()
        {
            return $"{Name} {Score}";
        }

        public int CompareTo(Hightscore xxx)
        {

            if (Score > xxx.Score)
            {
               return -1;
            }
            else if (Score < xxx.Score)
            {
                return 1;
            }

            return 0;
        }

    }
}
