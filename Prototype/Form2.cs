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
    public partial class Form2 : Form
    {
        Form3 frm2;
        Form10 frm;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click next to go to the next position, click back to go back, click write-in to write in a candidate who is not listed, and click next until you reach finish, and click finish!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BlockchainVotingLLC_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (frm2 == null)
            {
                frm2 = new Form3();
                frm2.FormClosed += frm2_FormClosed;
            }
            frm2.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (frm == null)
            {
                frm = new Form10();
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form4();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
