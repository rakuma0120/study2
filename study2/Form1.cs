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
            Menu[] menus = new Menu[]
            {
                new DrinkMenu("�������\�[�_", "�u�₩�ȊÂ����y���߂郁�����\�[�_�ł�", 300, true),
                new DrinkMenu("�R�[��", "�R�[���ł�", 200, true),
                new DrinkMenu("����", "���[������", 150, true),
                new MainMenu("���јa���X�e�[�L", "�W���[�V�[�ŏ_�炩�ȃX�e�[�L�ł��B", 3000, false),
                new MainMenu("�x�W�^�u���J���[", "��؂������Ղ�Ǝg�����A�X�p�C�V�[�ȃJ���[�ł��B", 2400, true),
            };

            MeneTableGenerator generator = new MeneTableGenerator(menus);
            generator.GenerateTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }

}
