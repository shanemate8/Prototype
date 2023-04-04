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
    public partial class BlockchainVotingLLC : Form
    {
        public BlockchainVotingLLC()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Start");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Form10();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}


