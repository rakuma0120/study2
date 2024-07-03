using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2.test
{
    public class Magician : Human
    {
        
        private int mp;
        
        public Magician(string name,int hp,string 性別,int mp) : base(name, hp, 性別)
        {
            this.mp = mp;
        }

        public int Mp
        {
            get { return mp; }
        }
        
        public override string SpecialAtack()
        {
            return (Mp * 2).ToString() + "ダメージの魔法攻撃をした！";
        }
    }
}
