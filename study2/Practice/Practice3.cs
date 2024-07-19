using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2.Practice
{
    public partial class TNT_Practice3 : Form
    {
        public TNT_Practice3()
        {
            InitializeComponent();
        }
        private bool IsKanaInput(char input)
        {
            // かな入力の範囲を定義
            int kanaStart = 0x3040;
            int kanaEnd = 0x309F;

            // 入力されたキーがかな入力かどうかを判定
            if (input >= kanaStart && input <= kanaEnd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登録しました");
        }
    }
}
