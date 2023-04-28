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
    public partial class Form4 : Form
    {
        Form2 frm2;
        Form5 frm;


        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Form2();
                frm2.FormClosed += frm2_FormClosed;
            }
            frm2.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (frm == null)
            {
                frm = new Form5();
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
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
