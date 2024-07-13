using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study2.Practice
{
    public partial class Practice2 : Form
    {
        public Practice2()
        {
            InitializeComponent();
        }

        private void Pass_Eye_Click(object sender, EventArgs e)
        {
            if (Pass_BOX.PasswordChar == '\0')
            {
                Pass_BOX.PasswordChar = '●';
            }
            else
            {
                Pass_BOX.PasswordChar = '\0';
            }
        }

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登録しました");
        }
    }
}
