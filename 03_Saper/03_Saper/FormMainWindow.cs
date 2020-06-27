using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Saper
{
    public partial class FormMainWindow : Form
    {
        private SaperLogic myGame;
        private const int fieldSize = 30;
        public FormMainWindow()
        {
            InitializeComponent();

            //wywołanie metody tworzącej na start prostą grę
            prostaToolStripMenuItem_Click(null, null);
        }
        private void prostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SaperLogic(8, 8, 10);
            generateView();
        }
        private void sredniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SaperLogic(12, 10, 25);
            generateView();
        }
        private void trudnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myGame = new SaperLogic(20, 15, 50);
            generateView();
        }

        private void generateView()
        {
            //kasowanie starych buttonów
            panelButtons.Controls.Clear();
            //generowanie nowych buttonow
            for(int x=0;x<myGame.BoardWidth;x++)
            {
                for(int y=0;y<myGame.BoardHeight;y++)
                {
                    Button b = new Button();
                    b.Size = new Size(fieldSize, fieldSize);
                    b.Location = new Point(fieldSize * x, fieldSize * y);
                    b.Click += button_Click;
                    panelButtons.Controls.Add(b);
                    //TAg jest typu object i mozna tam wstawić cokolwiek
                    //trzeba jednak później pamietac o kontroli i o konwersji typów
                    //kazdy przycisk oznaczam przy pomocy jego logicznego połozenia w odniesieniu do planszy gry
                    b.Tag = new Point(x, y);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(myGame.State==SaperLogic.GameState.InProgress)
            {
                if(sender is Button)
                {
                    Button b = sender as Button;
                    if(b.Tag is Point)
                    {
                        Point p = (Point)b.Tag;

                        myGame.Uncover(p);
                        refreshView();

                        if(myGame.State==SaperLogic.GameState.Win)
                        {
                            MessageBox.Show("Wygrana");
                        }
                        else if(myGame.State==SaperLogic.GameState.Loss)
                        {
                            MessageBox.Show("Przegrana");
                        }
                    }
                }
            }
        }

        private void refreshView()
        {
            foreach(Button b in panelButtons.Controls)
            {
                //pobieram z gry pole powiązane z danym buttonem
                SaperLogic.Field f=myGame.GetFiled((Point)b.Tag);
                if(f.Covered==false)
                {
                    if(f.FieldType==SaperLogic.FieldTypeEnum.Bomb)
                    {
                        b.BackColor = Color.Red;
                        b.Text = "@";

                    }
                    else
                    {
                        //dla obu rodzadjów pól
                        b.BackColor = Color.White;
                        //tylko dla pól z cyframi
                        if(f.FieldType==SaperLogic.FieldTypeEnum.BombCount)
                        {
                            b.Text = f.BombCount.ToString();
                        }
                    }
                }
            }
        }
    }
}

        //private void prostaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Button b = new Button();

        //    b.Location = new Point(50, 50);
        //    b.Size = new Size(100, 100);
        //    b.Text = "Dynamiczny button";

        //    b.Click += B_Click;
            
        //    this.Controls.Add(b);

        //}

        //private void B_Click(object sender, EventArgs e)
        //{
        //    Button b;
        //    if (sender is Button)
        //    {
        //        b = sender as Button;
        //        b.Text = "Po kliku";
        //    }

        //}