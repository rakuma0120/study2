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
            Person player = new Person("���c�r", 25);
            player.���ȏЉ�();

            //Person player2 = new Person();
            //player2.name = "���c����";
            //player2.age = 50;
            //player2.���ȏЉ�();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrinkMenu melonsoda = new DrinkMenu("�������\�[�_", "�u�₩�ȊÂ����y���߂郁�����\�[�_�ł�", 500, true);
            Debug.WriteLine(melonsoda.Name);
            Debug.WriteLine(melonsoda.GetPriceWiheTax());
            Debug.WriteLine(melonsoda.IsCold);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var melon = new DrinkMenu("�������\�[�_", "�u�₩�ȊÂ����y���߂郁�����\�[�_�ł�", 300, true);
            var cola = new DrinkMenu("�R�[��", "�R�[���ł�", 200, true);
            var tea = new DrinkMenu("����", "���[������", 150, true);
            var steak = new MainMenu("���јa���X�e�[�L", "�W���[�V�[�ŏ_�炩�ȃX�e�[�L�ł��B", 3000, false);
            var carry = new MainMenu("�x�W�^�u���J���[", "��؂������Ղ�Ǝg�����A�X�p�C�V�[�ȃJ���[�ł��B", 2400, true);

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

            Attacker attaker = new Attacker("shun", 100, "�j", 50);
            Debug.WriteLine(attaker.SpecialAtack());

            Magician magician = new Magician("haru", 150, "�j", 100);
            Debug.WriteLine(magician.SpecialAtack());

            Human[] humans = new Human[]
            {
                attaker,magician
            };

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DrinkMenu melonSoda = new DrinkMenu("�������\�[�_", "�u�₩�ȊÂ����y���߂郁�����\�[�_�ł��B", 400, true);
            DrinkMenu hotCoffee = new DrinkMenu("�z�b�g�R�[�q�[", "���J���������ꂽ�R�[�q�[�����g�p���Ă��܂��B", 500, false);
            
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



