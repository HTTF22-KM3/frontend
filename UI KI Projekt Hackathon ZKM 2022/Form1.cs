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

            this.img = Image.FromFile(@"Pics\Monke.jpg");
            pictureBox1.Image = this.img;
            trackBar1_Scroll(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }
        private void setZoomSlider()
        {
            trackBar1.UseWaitCursor = false;
            this.DoubleBuffered = true;
        }
        Bitmap ZoomPicture(Image img)
        {
            float zoomValue = trackBar1.Value / 50.0f;

            return new Bitmap(img, Convert.ToInt32(img.Width * zoomValue), Convert.ToInt32(img.Height * zoomValue));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

            pictureBox1.Image = ZoomPicture(this.img);
        } 

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = Convert.ToInt32(numericUpDown1.Value);
            //trackBar1_Scroll_1(sender, e);
            

        } 
    }
}
