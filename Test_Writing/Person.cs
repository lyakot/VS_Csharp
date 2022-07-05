using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Writing
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age}"; 
        }


        public int CompareTo(Person xxx)
        {

            return string.Compare(Name, xxx.Name);


            //if (Age > xxx.Age)
            //{
            //    return -1;
            //}
            //else if (Age < xxx.Age)
            //{
            //    return 1;
            //}    
          
            //return 0;
        }

    }
}
