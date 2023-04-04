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
        public string stdName {  get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new BlockchainVotingLLC();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form3();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
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
    }
}
