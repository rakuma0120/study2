using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    //主菜メニューの情報を格納するクラス（Menuから派生した子クラス）
    public class MainMenu : Menu
    {
        private bool isVegetarian;

        public MainMenu(string name, string description, int price, bool isVegetarian)
            : base(name, description, price)
        {
            this.isVegetarian = isVegetarian;
        }

        public bool IsVegetarian
        {
            get { return isVegetarian; }
        }
    }
}
