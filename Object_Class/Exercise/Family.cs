using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectExercise
{
    internal class Family
    {
        List<Person> families;
        public Family()
        {
            families = new List<Person>();
        }
        public void AddMember(Person member)
        {
            families.Add(member);
        }
        public Person GetOldestMember()
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < families.Count; i++)
            {
                if (families[i].age > max)
                {
                    max = families[i].age;
                    maxIndex = i;
                }
            }
            if (maxIndex != -1) return families[maxIndex];
            else return null;
        }
    }
}
