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
using study2.DatabaseClass;
using study2.Forms;

namespace study2.Login
{
    public partial class LoginIC : Form
    {

        User LoginUser;

        public LoginIC()
        {
            InitializeComponent();
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            if (TXT_ID.Text == "" || TXT_PW.Text == "")
            {
                MessageBox.Show("IDかPWを入力してください");
            }

            //データベースにアクセス

            // 2 接続文字列作成
            string connectionString = $"Data Source=.\\SQLEXPRESS;Initial Catalog='Practice';Integrated Security=True";
            // 接続成功時の処理
            try
            {
                // 3 SqlConnectionのインスタンスを作成
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 4 接続
                    connection.Open();
                    Debug.WriteLine("接続成功。");

                    // ここでデータベース操作を行う...
                    //ログインできない時
                    if (GetLoginInfomation(connection) == false)
                    {
                        MessageBox.Show("IDまたはパスワードが違います。");

                    }
                    else
                    {
                        var MainForm = new MainForm(LoginUser);
                        MainForm.ShowDialog();

                    }


                }
            }
            // 接続失敗の処理
            catch (SqlException e2)
            {
                Debug.WriteLine("接続エラー: " + e2.Message);
            }

            //データが取得できたらログイン
            //取得できなかったらメッセージ

        }

        //trueで返ればログイン成功、falseで返ればログイン失敗
        private bool GetLoginInfomation(SqlConnection connection)
        {
            // SQLクエリを実行するためのコマンドを作成
            string sql = "SELECT * FROM MST_USER ";
            sql += "Where ID = " + "'" + TXT_ID.Text + "'";
            sql += "AND   Password = " + "'" + TXT_PW.Text + "'";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // データ型に合わせて値を取得する
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string password = reader.GetString(2);
                        DateTime Birthday = reader.GetDateTime(3);
                        bool Delflag = reader.GetBoolean(4);
                        Debug.WriteLine($"ID: {id}, Name: {name}");

                        //ログインした人の情報をLoginUser変数に格納する
                        LoginUser = new User(id, name, password, Birthday, Delflag);


                        return true;
                    }
                }
            }

            return false;
        }

        private void BTN_Eye_Click(object sender, EventArgs e)
        {
            if (TXT_PW.PasswordChar == '\0')
            {
                TXT_PW.PasswordChar = '*';
            }
            else
            {
                TXT_PW.PasswordChar = '\0';
            }





        }

        private void TXT_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
