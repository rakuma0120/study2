using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2.test
{
    public class Attacker : Human
    {
        
        private int strength;

        public Attacker(string name, int hp, string 性別,int strength) : base(name, hp, 性別)
        {
            this.strength = strength;
        }

        public int Strength
        {
            get { return strength; }

        }

        public override string SpecialAtack()
        {
            return (Strength * 2).ToString()+"ダメージの物理攻撃をした！";
        }
    }
    
}