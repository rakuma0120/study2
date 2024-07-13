using study2.DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2.Forms
{
    public partial class UserIC : Form
    {

        private User _user;

        public UserIC(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void 保存_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("保存しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("保存しました");

            }
            else
            {
                MessageBox.Show("キャンセルしました");
            }
        }

        private void UserIC_Load(object sender, EventArgs e)
        {
            // データ型に合わせて値を取得する
            TXT_Name.Text  =  _user.Name;
            TXT_Birth.Text =  _user.Birthday.ToString();
            TXT_Pass.Text  =  _user.Password;

        }

    }
}
