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
    public partial class Главное_окно : Form
    {
        public Главное_окно()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Админ settingsForm = new Админ();

            // Show the settings form
            settingsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Окно2 settingsForm = new Окно2();

            // Show the settings form
            settingsForm.Show();
        }

        private void Главное_окно_Load(object sender, EventArgs e)
        {

        }
    }
}
