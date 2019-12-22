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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Btn_AddDel_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddDelWindowView class
            AddDelWindowView settingsForm = new AddDelWindowView();

            // Show the settings form
            settingsForm.Show();
        }

        private void Btn_Monitoring_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Окно3 class
            Окно3 settingsForm = new Окно3();

            // Show the settings form
            settingsForm.Show();
        }

        private void Админ_Load(object sender, EventArgs e)
        {

        }
    }
}
