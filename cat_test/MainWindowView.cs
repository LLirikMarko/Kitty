using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class MainWindowView : Form
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void Btn_Admin_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            AdminView settingsForm = new AdminView();

            // Show the settings form
            settingsForm.Show();
        }

        private void Btn_User_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Окно2 settingsForm = new Окно2();

            // Show the settings form
            settingsForm.Show();
        }

        private void Btn_Simulation_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            SimulationView settingsForm = new SimulationView();

            // Show the settings form
            settingsForm.Show();
        }

        private void MainWindowView_Load(object sender, EventArgs e)
        {

        }
    }
}
