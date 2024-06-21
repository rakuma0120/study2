using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    //Drinkメニュー（子クラス）
    public class DrinkMenu : Menu,IJsonWritable
    {
        //フィールド
        private bool isCold;


        //コンストラクタ
        public DrinkMenu(string name, string description, int price, bool iscold) : base(name, description, price)
        {
            this.isCold = iscold;
        }


        public bool IsCold
        {
            get { return isCold; }

        }
        public override string GetNote()
        {
            return IsCold ? " (冷) " : "";
        }

        public string ToJson()
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.AppendLine("{")
                       .AppendLine($"  \"Type\": \"Drink\",")
                       .AppendLine($"  \"Name\": \"{Name}\",")
                       .AppendLine($"  \"Description\": \"{Description}\",")
                       .AppendLine($"  \"Price\": {Price},")
                       .AppendLine($"  \"IsCold\": {IsCold.ToString().ToLower()}")
                       .Append("}");
            return jsonBuilder.ToString();

        }

    }
}
