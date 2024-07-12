using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using study2.test;

namespace study2.Practice
{
    public partial class Practice1 : Form
    {
        public Practice1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form3();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
