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
    
    public partial class Form7 : Form
    {
        Form3 frm2;
        Form6 frm;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                frm = new Form6();
                frm.FormClosed += frm2_FormClosed;
                frm.stdName = textBox1.Text;
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
