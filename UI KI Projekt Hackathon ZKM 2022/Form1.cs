using System;
using System.Diagnostics;
using System.ComponentModel;

namespace UI_KI_Projekt_Hackathon_ZKM_2022
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\kacpe\AppData\Local\Programs\Python\Python38-32\python.exe";
            start.Arguments = @"main.py";
            start.WorkingDirectory = @"C:\Users\kacpe\PycharmProjects\Palindrom";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show(result);

                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}