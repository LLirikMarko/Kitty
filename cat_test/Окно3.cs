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
    public partial class Окно3 : Form
    {
        public Окно3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form3 settingsForm = new Form3();

            // Show the settings form
            settingsForm.Show();
        }
    }
}
