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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            System.IO.File.WriteAllLines(@"C:\Users\nomuu\source\repos\Prototype\Prototype\Information.txt", contents);
            this.Hide();

            if (FileEquals(@"C:\Users\nomuu\source\repos\Prototype\Prototype\DeathRecord.txt",
                @"C:\Users\nomuu\source\repos\Prototype\Prototype\Information.txt") == true)
            {
                MessageBox.Show("This person is in the death record!", "Caption");
            }
            else {
                MessageBox.Show("You may continue!", "Caption");
            }

            var form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);

            for (int i = 0; i < file1.Length; i++)
            {
                if (file1[i] == file2[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        
            

    }
}
