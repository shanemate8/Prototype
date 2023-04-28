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
        Form10 frm2;
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
            if (frm2 == null)
            {
                frm2 = new Form10();
                frm2.FormClosed += frm2_FormClosed;
                

            }
            
            frm2.Show(this);
            Hide();
            

        }
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;
            Show();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}


