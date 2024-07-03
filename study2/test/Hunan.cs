using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2.test
{
    public abstract class Human
    {
        private string name;
        private int hp;
        private string gender;

        public Human(string name, int hp, string 性別)
        {
            this.name = name;
            this.hp = hp;
            this.gender = 性別;
        }
        public string Name
        {
            get { return name; }
        }

        public int HP
        {
            get { return hp; }

        }
        public string Gender
        {
            get { return gender; }

        }
        public abstract string SpecialAtack();

    }
}
