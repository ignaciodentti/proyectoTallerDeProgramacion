using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalTallerDeProgramacion.Views
{
    public partial class ViewLoginClient : Form
    {
        public ViewLoginClient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        private void textBoxDNI_keyup(object sender, EventArgs e)
        {
            if (!Regex.Match(textBoxDNI.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // last name was incorrect  
                MessageBox.Show("Invalid last name", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                lastNameTextBox.Focus();
                return;
            }
        }
    }
}
