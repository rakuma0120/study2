using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2
{
    public class MeneTableGenerator
    {
        private Menu[] menus;

        public MeneTableGenerator(Menu[] menus)
        {
            this.menus = menus;
        }

        public string GenerateTable()
        {
            string table = "<table border='1'>";
            table += "<tr><th>メニュー名</th><th>価格(税込み)</th><th>説明</th></tr>\n";
            foreach (Menu menu1 in menus)
            {
                table += "<tr>";
                table += $"<td>{menu1.Name}</td>";
                table += $"<td>{menu1.GetPriceWiheTax()}円</td>";
                table += $"<td>{menu1.Description}</td>";
                table += $"<td>{menu1.GetNote()}</td>";
                table += "</tr>\n";
                //※ +演算子で多数の文字列を連結させていくのは効率が悪いため、
                //    本当はStringBuilderクラスを使った方が良いです。
            }
            table += "</table>";
            return table;
        }
    }
}
