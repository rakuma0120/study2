using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using study2.DatabaseClass;

namespace study2.Forms
{
    public partial class MainForm : Form
    {
        private User _user;

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        public MainForm()
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userIC = new UserIC(_user);
            
            userIC.ShowDialog();
        }
    }
}
