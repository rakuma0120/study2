using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    //メニュー情報を格納する親クラス
     public abstract class Menu
    {
        //フィールド
        private string name;
        private string description;
        private int price;

        //コンストラクタ
        public Menu(string name, string description, int price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        //プロパティ
        public string Name
        {
            get { return name; }

        }

        public string Description
        {
            get { return description ; }

        }

        public int Price
        {
            get { return price; }

        }

        public int GetPriceWiheTax()
        {
            const double taxRate = 0.1; // 消費税率10%
            return (int)Math.Round(Price * (1 + taxRate));
        }
        
        //抽象メソッド
        public abstract string GetNote();





    }
}
