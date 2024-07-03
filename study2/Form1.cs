using System.Diagnostics;
using System.Drawing.Imaging;
using System.Xml.Serialization;
using study2.test;

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

            var melon = new DrinkMenu("メロンソーダ", "爽やかな甘さが楽しめるメロンソーダです", 300, true);
            var cola = new DrinkMenu("コーラ", "コーラです", 200, true);
            var tea = new DrinkMenu("お茶", "おーいお茶", 150, true);
            var steak = new MainMenu("黒毛和牛ステーキ", "ジューシーで柔らかなステーキです。", 3000, false);
            var carry = new MainMenu("ベジタブルカレー", "野菜をたっぷりと使った、スパイシーなカレーです。", 2400, true);

            Menu[] menus = new Menu[]
            {
                melon,cola, tea, steak, carry
            };

            MeneTableGenerator generator = new MeneTableGenerator(menus);
            generator.GenerateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Attacker attaker = new Attacker("shun", 100, "男", 50);
            Debug.WriteLine(attaker.SpecialAtack());

            Magician magician = new Magician("haru", 150, "男", 100);
            Debug.WriteLine(magician.SpecialAtack());

            Human[] humans = new Human[]
            {
                attaker,magician
            };

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DrinkMenu melonSoda = new DrinkMenu("メロンソーダ", "爽やかな甘さが楽しめるメロンソーダです。", 400, true);
            DrinkMenu hotCoffee = new DrinkMenu("ホットコーヒー", "丁寧に焙煎されたコーヒー豆を使用しています。", 500, false);
            
            IJsonWritable[] drinks = new IJsonWritable[] { melonSoda, hotCoffee};
            JsonGenerator generator = new JsonGenerator();
            string json = generator.GenerateJson(drinks);
            Console.WriteLine(json);
            
        }

        private string GetString(int cnt)
        {
            if(cnt < 10)
            {
                return "aiueo";
            }
            else
            {
                return "kakikukeko";
            }

        }

    }

}



