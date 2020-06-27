using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _088_EditorIcons
{
    public partial class FormMainEditor : Form
    {
        DatabaseIconsDataContext DC = new DatabaseIconsDataContext();
        const int FieldSize = 20;
        Point tempPoint;
        public FormMainEditor()
        {
            InitializeComponent();

            LoadIconList();

        }

        private void LoadIconList(Icon SelectedIcon = null)
        {
            comboBoxIconList.Items.Clear();
            comboBoxIconList.Items.AddRange(DC.Icons.ToArray());
            if(SelectedIcon != null)
            {
                comboBoxIconList.SelectedItem = SelectedIcon;
            }
        }

        private void comboBoxIconList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                textBoxIconName.Text = selectedIcon.Name;
                numericUpDownIconSize.Value = selectedIcon.Size;
                RepaintIcon();
            }

        }

        private void RepaintIcon()
        {
            
 
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                pictureBoxIconEditor.Image = new Bitmap(selectedIcon.Size * FieldSize, selectedIcon.Size * FieldSize);
                Graphics g = Graphics.FromImage(pictureBoxIconEditor.Image);
                
                foreach(IconPoint ip in selectedIcon.IconPoints)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(ip.Color)),
                                    ip.X * FieldSize,
                                    ip.Y * FieldSize, 
                                    FieldSize - 1, 
                                    FieldSize - 1);
                }

                for (int x = 0; x <selectedIcon.Size;x++)
                {
                    for (int y = 0; y < selectedIcon.Size; y++)
                    {
                        g.DrawRectangle(new Pen(Color.Gray), x * FieldSize, y * FieldSize, FieldSize - 1, FieldSize - 1);
                    }
                }
                pictureBoxIconEditor.Refresh();
                    
            }
        }

        private void textBoxIconName_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                selectedIcon.Name = textBoxIconName.Text;
                DC.SubmitChanges();

                LoadIconList(selectedIcon);
            }
        }

        private void numericUpDownIconSize_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;
                selectedIcon.Size= (int)numericUpDownIconSize.Value ;
                DC.SubmitChanges();
                LoadIconList(selectedIcon);
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = buttonColor.BackColor;
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }    
        }

        //private void pictureBoxIconEditor_MouseMove(object sender, MouseEventArgs e)
        //{

        //    if (e.Button == MouseButtons.Left)
        //    {

        //    }

        //}

        private void pictureBoxIconEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {
                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;

                if (selectedIcon.IconPoints.Count(p => p.X == e.X / FieldSize &&
                                                       p.Y == e.Y / FieldSize) > 0)
                {
                    DC.IconPoints.DeleteAllOnSubmit(selectedIcon.IconPoints.Where(p => p.X == e.X / FieldSize
                                                                                   && p.Y == e.Y / FieldSize));
                }
                else
                {
                    IconPoint ip = new IconPoint();
                    ip.X = e.X / FieldSize;
                    ip.Y = e.Y / FieldSize;
                    ip.Color = buttonColor.BackColor.ToArgb();

                    //selectedIcon.IconPoints.Add(ip);

                    ip.Icon = selectedIcon;
                }

                DC.SubmitChanges();
                LoadIconList(selectedIcon);
            }
        }

        //private void pictureboxiconeditor_mousemove(object sender, mouseeventargs e)
        //{

        //}

        //private void pictureboxiconeditor_mousedown(object sender, mouseeventargs e)
        //{

        //}

        //private void pictureboxiconeditor_mouseup(object sender, mouseeventargs e)
        //{

        //}

        private void dodajNowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Icon newIcon = new Icon();
            newIcon.Name = "Nowa";
            newIcon.Size = 10;

            DC.Icons.InsertOnSubmit(newIcon);
            DC.SubmitChanges();
            LoadIconList(newIcon);
        }

        private void eksportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxIconList.SelectedItem != null)
            {

                Icon selectedIcon = comboBoxIconList.SelectedItem as Icon;

                SaveFileDialog dial = new SaveFileDialog();
            dial.Filter = "Ikony|*.ico";
                //dial.Filter = "Ikony|*.png";

                if (dial.ShowDialog() == DialogResult.OK)
                {
                    Bitmap ico = new Bitmap(selectedIcon.Size, selectedIcon.Size);
                    Graphics gi = Graphics.FromImage(ico);
                    
                    foreach (IconPoint ip in selectedIcon.IconPoints)
                    {
                        gi.FillRectangle(new SolidBrush(Color.FromArgb(ip.Color)),
                                        ip.X ,
                                        ip.Y ,
                                        1,
                                       1);
                    }

                    ico.Save(dial.FileName, ImageFormat.Icon);
                }  

            }
        }

        
    }
}
