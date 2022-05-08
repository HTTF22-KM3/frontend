using System;
using System.Diagnostics;
using System.ComponentModel;

namespace UI_KI_Projekt_Hackathon_ZKM_2022
{
    public partial class Form1 : Form
    {
        private Image img;

        public Form1()
        {
            InitializeComponent();
            setZoomSlider();

            this.img = Image.FromFile(@"C:\Users\Notebook-ADM\Downloads\image.jpg");
            pictureBox1.Image = this.img;
            ZoomBar_Scroll(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ZoomBar_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = ZoomPicture(this.img);
        }
        private void setZoomSlider()
        {
            ZoomBar.UseWaitCursor = false;
            this.DoubleBuffered = true;
        }
        Bitmap ZoomPicture(Image img)
        {
            float zoomValue = (Convert.ToSingle(ZoomBar.Value) + 1.0f) / 100.0f;

            return new Bitmap(img, Convert.ToInt32(img.Width * zoomValue), Convert.ToInt32(img.Height * zoomValue));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

/*ProcessStartInfo start = new ProcessStartInfo();
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
            }*/