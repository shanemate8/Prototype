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
    public partial class Form3 : Form
    {
        Form2 frm2;
        Form7 frm;
        public Form3()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click next to go to the next position, click back to go back, click write-in to write in a candidate who is not listed, and click next until you reach finish, and click finish!");

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Form7();
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
    }
}
