using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cat_test
{
    public partial class Окно2 : Form
    {
        public Окно2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Пользователь settingsForm = new Пользователь();

            // Show the settings form
            settingsForm.Show();
        }
    }
}
