using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLesson
{
    internal class Human
    {
        public string Name;

        public override bool Equals(object? obj)
        {
            if (obj is Human human) return this.Name == human.Name;
            else return false;
            //return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

    }
}
