using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalTallerDeProgramacion.Views
{
    public partial class LoginPIN : Form
    {

        public LoginPIN(int pDNI, LoginDNI pLoginDNI)
        {
            InitializeComponent();
            this.dni = pDNI;
            this.pLoginDNI = pLoginDNI;
        }

        public int dni { get; set; }

        public LoginDNI pLoginDNI { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '1';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '2';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '3';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '4';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '5';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '6';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '7';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '8';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '9';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length < 4)
            {
                textBoxPIN.Text = textBoxPIN.Text + '0';
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length > 0)
            {
                textBoxPIN.Text = textBoxPIN.Text.Remove(textBoxPIN.Text.Length - 1);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxPIN.Text.Length > 0)
            {
                //siguiente pag de pin
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error");
            }
        }

        private void eventardo(object sender, MouseEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            pLoginDNI.Show();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"USER: {this.dni} PIN {textBoxPIN.Text}", "Error");
        }
    }
}
