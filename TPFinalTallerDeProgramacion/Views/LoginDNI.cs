﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinalTallerDeProgramacion.Views;

namespace TPFinalTallerDeProgramacion.Views
{
    public partial class LoginDNI : Form
    {



        public LoginDNI()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '1';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '2';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '3';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '4';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '5';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '6';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '7';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '8';
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '9';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length < 8)
            {
                textBoxDNI.Text = textBoxDNI.Text + '0';
            }
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length > 0)
            {
                textBoxDNI.Text = textBoxDNI.Text.Remove(textBoxDNI.Text.Length - 1);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eventardo(object sender, MouseEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginDNI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (textBoxDNI.Text.Length == 8)
            {
                int pDNI = Convert.ToInt32(textBoxDNI.Text);
                LoginPIN LoginPINWindow = new LoginPIN(pDNI,this);
                this.Hide();
                LoginPINWindow.Show();
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error");
            }
        }
    }
}
