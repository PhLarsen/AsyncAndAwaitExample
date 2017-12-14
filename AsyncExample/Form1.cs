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
using System.Threading;
namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async Task<int> CountCharactersAsync()
        {
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader("c:\\AsyncAndAwait.txt"))
                {
                    string content = reader.ReadToEnd();
                    count = content.Length;
                    await Task.Delay(5000);
                }
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Couldn't find  the file");
            }
            return count;
        }

        private int CountCharacters()
        {
            int count = 0;
            try
            {
                using (StreamReader reader = new StreamReader("c:\\AsyncAndAwait.txt"))
                {
                    string content = reader.ReadToEnd();
                    count = content.Length;
                    Thread.Sleep(5000);
                }
                
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Couldn't find  the file");
            }
            return count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            

            lblCount.Text = "Processing File. Please wait...";
            int count = await CountCharactersAsync();
            lblCount.Text = count.ToString() + " characters in file";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCountNonAsync.Text = "Processing File. Please wait...";
            int count = CountCharacters();
            lblCountNonAsync.Text = count.ToString() + " characters in file";
        }
    }
}
