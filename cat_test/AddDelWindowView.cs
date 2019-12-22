using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pres;

namespace cat_test
{
    public partial class AddDelWindowView : Form, IAddUser
    {
        public AddDelWindowView()
        {
            InitializeComponent();
        }

        public string UserName => textBox1.Text;

        public event Action AddUser;
        private void Button_Add(object sender, EventArgs e)
        {
            AddUser.Invoke();   
        }

        private void Окно1_Load(object sender, EventArgs e)
        {

        }
    }
}
