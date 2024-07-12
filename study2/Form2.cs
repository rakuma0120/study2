using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //キャンセルになってしまう
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("保存しました");
            }
            else
            {
                MessageBox.Show("キャンセルしました");
            }
        }


    }

}


