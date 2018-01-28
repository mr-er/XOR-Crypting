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

namespace XOR_Crypting_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string inputFile;
        private string outputFile;
        private string passwordFile;

        private void button1_Click(object sender, EventArgs e)
        {
            readInputFile();
        }

        //Wczytywanie danych wejściowych 
        private void readInputFile()
        {      
            OpenFileDialog openInputFile = new OpenFileDialog();
            openInputFile.Title = "Otwórz plik z danymi wejściowymi";
            openInputFile.Filter = "Text files (*.txt)|*.txt";
            if (openInputFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openInputFile.FileName));

                inputFile = read.ReadToEnd();
                read.Dispose();
                richTextBox1.Text = richTextBox1.Text + "<<Wczytano dane wejściowe o długości "+ inputFile.Length +">>\n";
                if (inputFile.Length < 100)
                {
                    richTextBox1.Text = richTextBox1.Text + "<<\n" + inputFile + "\n>>\n";
                }
                outputFile = inputFile;
                button1.Enabled = false;
                button5.Enabled = true;
            }
        }

        //Zapisowanie pliku wyjściowego 
        private void button2_Click(object sender, EventArgs e)
        {   
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Zapisz plik z danymi wyjściowymi";
            save.Filter = "Text files (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(outputFile);
                write.Dispose();
                richTextBox1.Text = "<<Zapisano plik z danymi wyjściowymi>>\n";

                button2.Enabled = false;
                button1.Enabled = true;
                button6.Enabled = false;
                button5.Enabled = false; 
            }
        }

        //Wykonywanie szyfrowania
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                outputFile = doXor(outputFile, richTextBox2.Text);
                richTextBox1.Text = richTextBox1.Text + "<<Dane zaszyfrowane>>\n";
                if (outputFile.Length < 100)
                {
                    richTextBox1.Text = richTextBox1.Text + "<<\n" + outputFile;
                    richTextBox1.Text = richTextBox1.Text + "\n>>\n";
                }
                button5.Enabled = false;
                button6.Enabled = true;
                button2.Enabled = true;
            }
            catch
            {
                richTextBox1.Text = richTextBox1.Text + "<<Plik wejściowy oraz hasło muszą zawierać przynajmniej jeden znak.>>\n";
            }
        }

        //Szyfrowanie
        private string doXor(string inputFile, string inputPassword)
        {
                char[] input = inputFile.ToArray();
                char[] password = inputPassword.ToArray();
                char[] output = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    output[i] = (char)(input[i] ^ password[i % password.Length]);
                }
                return new string(output);
        }


        //Zapisywanie hasła do pliku
        private void button3_Click(object sender, EventArgs e)
        { 
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Zapisz plik z hasłem";
            save.Filter = "Password files (*.password)|*.password";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(richTextBox2.Text);
                write.Dispose();
                richTextBox1.Text = richTextBox1.Text + "<<Zapisano plik z hasłem>>\n";
            }
        }
        
        //Wczytywanie hasła 
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPasswordFile = new OpenFileDialog();
            openPasswordFile.Title = "Otwórz plik z hasłem";
            openPasswordFile.Filter = "Password files (*.password)|*.password";
            if (openPasswordFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openPasswordFile.FileName));

                passwordFile = read.ReadToEnd();
                read.Dispose();
                richTextBox2.Text = passwordFile;
                richTextBox1.Text = richTextBox1.Text + "<<Wczytano hasło o długości " + passwordFile.Length + ">>\n";
            }
        }

        //Deszyfrowanie pliku
        private void button6_Click(object sender, EventArgs e)
        {
            outputFile = doXor(outputFile, richTextBox2.Text);
            richTextBox1.Text = richTextBox1.Text + "<<Plik został rozszyfrowany.>>\n";
            if (inputFile.Length < 100)
            {
                richTextBox1.Text = richTextBox1.Text + "<<\n" + outputFile + "\n>>\n";
            }
            button6.Enabled = false;
            button5.Enabled = true; 
        }
    }

}
