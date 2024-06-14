using System.Diagnostics;
using System.Drawing.Imaging;

namespace study2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person player = new Person("高田俊", 25);
            player.自己紹介();

            //Person player2 = new Person();
            //player2.name = "高田尚代";
            //player2.age = 50;
            //player2.自己紹介();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrinkMenu melonsoda = new DrinkMenu("メロンソーダ", "爽やかな甘さが楽しめるメロンソーダです", 500, true);
            Debug.WriteLine(melonsoda.Name);
            Debug.WriteLine(melonsoda.GetPriceWiheTax());
            Debug.WriteLine(melonsoda.IsCold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu[] menus = new Menu[]
            {
                new DrinkMenu("メロンソーダ", "爽やかな甘さが楽しめるメロンソーダです", 300, true),
                new DrinkMenu("コーラ", "コーラです", 200, true),
                new DrinkMenu("お茶", "おーいお茶", 150, true),
                new MainMenu("黒毛和牛ステーキ", "ジューシーで柔らかなステーキです。", 3000, false),
                new MainMenu("ベジタブルカレー", "野菜をたっぷりと使った、スパイシーなカレーです。", 2400, true),
            };

            MeneTableGenerator generator = new MeneTableGenerator(menus);
            generator.GenerateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }

}
