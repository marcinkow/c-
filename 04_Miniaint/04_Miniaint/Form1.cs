using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Miniaint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Point tempPoint;
        Pen myPen;
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = saveFileDialog.Filter = "Grafika BMP|*.bmp|Grafika PNG|*.png|Grfika JPG|*.jpg";
            myPen = new Pen(kolor.BackColor, (float)numericUpDownWidth.Value);
            myPen.EndCap = myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            nowyToolStripMenuItem_Click(null, null);

        }
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMyImage.Image = new Bitmap(800, 600);
            graphics = Graphics.FromImage(pictureBoxMyImage.Image);
            graphics.Clear(Color.White);

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBoxMyImage.Image= Image.FromFile(openFileDialog.FileName);
                 graphics = Graphics.FromImage(pictureBoxMyImage.Image);

            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                pictureBoxMyImage.Image. Save(saveFileDialog.FileName );
            }

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat imageFormat = ImageFormat.Bmp;
                string rozszerzenie = Path.GetExtension(saveFileDialog.FileName);
                switch(rozszerzenie)
                {
                    case ".bmp":
                        imageFormat = ImageFormat.Bmp;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;

                }
                

                pictureBoxMyImage.Image.Save(saveFileDialog.FileName, imageFormat);
            }

        }

        private void pictureBoxMyImage_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left )
            {
                // graphics.DrawEllipse(new Pen(Color.Red), e.X, e.Y, 20, 20);
                //pictureBoxMyImage.Refresh();

                tempPoint = e.Location;
            }        
        }

        private void pictureBoxMyImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(radioButtonCurve.Checked)
                {
                     graphics.DrawLine(myPen, tempPoint, e.Location);
                    pictureBoxMyImage.Refresh();
                    tempPoint = e.Location; 
                }
                
            }
            
        }

        private void pictureBoxMyImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonCurve.Checked)
                {
                    graphics.DrawLine(myPen, tempPoint, e.Location);
                    
                }
                else if(radioButtonLine.Checked)
                {
                    graphics.DrawLine(myPen, tempPoint, e.Location);
                }
                else if (radioButtonRectangle.Checked)
                {
                    
                    graphics.DrawRectangle(myPen,Math.Min(tempPoint.X,e.X), 
                                                 Math.Min(tempPoint.Y, e.Y), 
                                                 Math.Abs(tempPoint.X - e.X),
                                                 Math.Abs(tempPoint.Y - e.Y));
                    if (checkBox1.Checked)
                    {
                        graphics.FillRectangle(new SolidBrush(button1.BackColor), Math.Min(tempPoint.X, e.X),
                                                 Math.Min(tempPoint.Y, e.Y),
                                                 Math.Abs(tempPoint.X - e.X),
                                                 Math.Abs(tempPoint.Y - e.Y));
                    }
                }
                else if (radioButtonEllipsa.Checked)
                {
                    graphics.DrawEllipse(myPen, Math.Min(tempPoint.X, e.X),
                                                Math.Min(tempPoint.Y, e.Y),
                                                Math.Abs(tempPoint.X - e.X),
                                                Math.Abs(tempPoint.Y - e.Y));
                    if (checkBox1.Checked)
                    {
                        graphics.FillEllipse(new SolidBrush(button1.BackColor), Math.Min(tempPoint.X, e.X),
                                                    Math.Min(tempPoint.Y, e.Y),
                                                    Math.Abs(tempPoint.X - e.X),
                                                    Math.Abs(tempPoint.Y - e.Y));
                    }
                }
                pictureBoxMyImage.Refresh();
            }
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            myPen.Width = (float)numericUpDownWidth.Value;
        }

        private void kolor_Click(object sender, EventArgs e)
        {
            if(colorDialogLine.ShowDialog() == DialogResult.OK)
            {
                kolor.BackColor = colorDialogLine.Color;
                myPen.Color = colorDialogLine.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

       
    }
}
