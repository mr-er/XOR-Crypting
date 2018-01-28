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

        private string outputFile;


        //Wczytywanie danych wejściowych 
        private void button1_Click(object sender, EventArgs e)
        {
            outputFile = readFile("Wczytaj plik do zaszyfrowania", "Text files (*.txt)|*.txt", " wejściowego", " wejściowego");
            if (outputFile.Length > 0)
            {
                bDoXOR.Enabled = true;
            }
            else
            {
                bDoXOR.Enabled = false;
            }
        }

        //Metoda zapisująca pliki
        private bool saveFile(string title, string filter, string file, string opening, string closing)
        {
            rTBConsole.Text = rTBConsole.Text + "<<Zapisywanie pliku" + opening + ">>\n";
            SaveFileDialog save = new SaveFileDialog();
            save.Title = title;
            save.Filter = filter;
            bool result = save.ShowDialog() == DialogResult.OK;
            if (result)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(file);
                write.Dispose();
                rTBConsole.Text = rTBConsole.Text + "<<Zapisano plik ''" + save.FileName + "''>>\n";
                return result; 
            }
            else
            {
                rTBConsole.Text = rTBConsole.Text + "<<Przerwano zapisywanie pliku" + closing + ">>\n";
                return result;
            }
        }

        //Metoda wczytująca pliki 
        private string readFile(string title, string filter, string opening, string closing)
        {
            rTBConsole.Text = rTBConsole.Text + "<<Wczytywanie pliku"+opening+">>\n";
            string file = "";
            OpenFileDialog openInputFile = new OpenFileDialog();
            openInputFile.Title = title;
            openInputFile.Filter = filter;

            if (openInputFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openInputFile.FileName));

                file = read.ReadToEnd();
                read.Dispose();
                rTBConsole.Text = rTBConsole.Text + "<<Wczytano plik ''" + openInputFile.FileName + "''>>\n";
                //Jeżeli długość mniejsza niż 100 to zwartość pliku zostanie wyświetlona w konsoli. 
                if (file.Length < 100)
                {
                    rTBConsole.Text = rTBConsole.Text + "<<\n" + file + "\n>>\n";
                    return file;
                }
                return file;
            }
            else
            {
                rTBConsole.Text = rTBConsole.Text + "<<Przerwano wczytywanie pliku"+closing+">>\n";
                return file;
            }
        }


        //Zapisowanie pliku wyjściowego 
        private void button2_Click(object sender, EventArgs e)
        {
            saveFile("Zapisowanie pliku wyjściowego", "Text files(*.txt) | *.txt", outputFile, " wyjściowego", " wyjściowego");
        } 

        //Wykonywanie szyfrowania
        private void button5_Click(object sender, EventArgs e)
        {
            rTBConsole.Text = rTBConsole.Text + "<<Próba szyfrowania>>\n";
            try
            {
                outputFile = doXor(outputFile, rTBPassword.Text);
                if (outputFile.Length < 100)
                {
                    rTBConsole.Text = rTBConsole.Text + "<<\n" + outputFile;
                    rTBConsole.Text = rTBConsole.Text + "\n>>\n";
                }
                rTBConsole.Text = rTBConsole.Text + "<<Próba udana>>\n";
                bSaveOutputToFile.Enabled = true;
            }
            catch
            {
                rTBConsole.Text = rTBConsole.Text + "<<Plik wejściowy oraz hasło muszą zawierać przynajmniej jeden znak.>>\n";
                rTBConsole.Text = rTBConsole.Text + "<<Próba nieudana>>\n";
            }
        }

        //Algorytm szyfrujący
        private string doXor(string file, string inputPassword)
        {
                char[] inputFile = file.ToArray();
                char[] password = inputPassword.ToArray();
                char[] output = new char[file.Length];
                for (int i = 0; i < file.Length; i++)
                {
                    output[i] = (char)(inputFile[i] ^ password[i % password.Length]);
                }
                return new string(output);
        }


        //Zapisywanie hasła do pliku
        private void button3_Click(object sender, EventArgs e)
        {
            saveFile("Zapisowanie pliku z hasłem", "Password files(*.password) | *.password", rTBPassword.Text, " z hasłem", " z hasłem");
        }
        
        //Wczytywanie hasła 
        private void button4_Click(object sender, EventArgs e)
        {
            rTBPassword.Text = readFile("Wczytaj plik z hasłem", "Password files (*.password)|*.password", " z hasłem", " z hasłem");
        }



    }

}
