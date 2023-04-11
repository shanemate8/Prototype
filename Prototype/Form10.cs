using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;

namespace Prototype
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void President_Click(object sender, EventArgs e)
        {

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
            string[] contents = new string[4];
            contents[0] = "First Name: " + textBox1.Text;
            contents[1] = "Last Name: " + textBox2.Text;
            contents[2] = "Date of Birth: " + textBox3.Text;
            contents[3] = "VUID: " + textBox4.Text;
            System.IO.File.WriteAllLines(@"C:\Users\shane\Documents\Information.txt", contents);
            this.Hide();
            var form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
