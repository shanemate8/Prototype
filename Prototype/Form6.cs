﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form6 : Form
    {
        Form2 frm2;
        public string stdName { get; set; }
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Form2();
                frm2.FormClosed += frm2_FormClosed;
            }
            frm2.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you ready to submit?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Submitted!");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;
            Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click next to go to the next position, click back to go back, click write-in to write in a candidate who is not listed, and click next until you reach finish, and click finish! ");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = stdName;
        }
        private void label1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
