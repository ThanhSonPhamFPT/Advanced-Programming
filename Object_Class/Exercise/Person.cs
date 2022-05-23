using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectExercise
{
    internal class Person:IComparable<Person>
    {
        public string name;
        public int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person():this("No name",1)
        {

        }
        public Person(int age):this("No name", age)
        {

        }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            else return this.name.CompareTo(other.name);
        }
    }
}
