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
            string a = @"C:\Users\nomuu\source\repos\Prototype\Prototype\DeathRecord.txt";
            string b = @"C:\Users\nomuu\source\repos\Prototype\Prototype\Information.txt";
            if (FileEquals(a, b) == true)
            {
                MessageBox.Show("This name is in the death record");
            }
            else {
                MessageBox.Show("You may continue");
            }

            var form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = System.IO.File.ReadAllBytes(path1);
            byte[] file2 = System.IO.File.ReadAllBytes(path2);

            for (int i = 0; i < 3; i++)
            {
                if (file1[i] != file2[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        
            

    }
}
