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

            System.IO.File.AppendAllText(@"C:\Users\shane\source\repos\Prototype\Prototype\blockchain.txt", contents[3] + "\n");
            MessageBox.Show("You were added to the blockchain!");
            // Must be changed to local directory
            System.IO.File.WriteAllLines(@"C:\Users\shane\source\repos\Prototype\Prototype\Information.txt", contents);

            // Must be changed to local directory
            string userFile = "C:\\Users\\shane\\source\\repos\\Prototype\\Prototype\\BlockchainUser1.txt";
            string info = "C:\\Users\\shane\\source\\repos\\Prototype\\Prototype\\Information.txt";
            string deathRecord = @"C:\Users\shane\source\repos\Prototype\Prototype\DeathRecord.txt";
            if (FileEquals(deathRecord,info))
            {
                MessageBox.Show("This name is in the death record");
            }
            else if (FileEquals(userFile,info))
            {

                this.Hide();
                var form2 = new Form2();
                form2.FormClosed += (s, args) => this.Close();
                form2.Show();

            }
            else
            {
                MessageBox.Show("User is not registered!");
            }
        }

        /*
         *  Compares file, returns true if they are the same 
         */
        private Boolean FileEquals(string userFile, string info)
        {
            byte[] bytes1 = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(System.IO.File.ReadAllText(userFile)));
            byte[] bytes2 = Encoding.Convert(Encoding.GetEncoding(1252), Encoding.ASCII, Encoding.GetEncoding(1252).GetBytes(System.IO.File.ReadAllText(info)));

            if (Encoding.ASCII.GetChars(bytes1).SequenceEqual(Encoding.ASCII.GetChars(bytes2)))
            {
                return true;
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
