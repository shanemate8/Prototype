using System;
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
    public partial class Form5 : Form
    {
        Form10 frm2;
        Form3 frm;

        public string stdName {  get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Form10();
                frm2.FormClosed += frm2_FormClosed;
            }
            frm2.Show(this);
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Form3();
                frm.FormClosed += frm2_FormClosed;
            }
            frm.Show(this);
            Hide();
        }
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;
            frm = null;
            Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click next to go to the next position, click back to go back, click write-in to write in a candidate who is not listed, and click next until you reach finish, and click finish!");
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = stdName;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
