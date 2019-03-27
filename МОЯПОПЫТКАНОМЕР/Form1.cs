using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МОЯПОПЫТКАНОМЕР
{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        Parallelepiped parallelepiped;
        int IDcountRect = 0;
        int IDcountParallel = 0;

        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle();
            parallelepiped = new Parallelepiped();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rectangle.Height = Convert.ToDouble(textHeight.Text == " " ? "0" : textHeight.Text);
            parallelepiped.HeightBase = rectangle.Height;
            rectangle.Width = Convert.ToDouble(textWigth.Text == " " ? "0" : textWigth.Text);
            parallelepiped.WidthBase = rectangle.Width;
            richTextBox2.Text = rectangle.ToString();

            parallelepiped.Height_of_paralle = Convert.ToDouble(textHeigth_par.Text == " " ? "0" : textHeigth_par.Text);
            richTextBox1.Text = parallelepiped.ToString();
        }

        private void AddToGrid_Click(object sender, EventArgs e)
        {
            dataGridRect.Rows.Add(++IDcountRect, rectangle.Get_Square(), rectangle.Width, rectangle.Height, rectangle.Get_Diag(),
                rectangle.Get_Perimeter());
            dataGridParallel.Rows.Add(++IDcountParallel, parallelepiped.Height_of_paralle, parallelepiped.WidthBase,
                parallelepiped.Get_Volume());
        }

        private void searchRectAndCube_Click(object sender, EventArgs e)
        {
            int count = 0;
            int averageSquare = 0;
            for (int i = 0; i < dataGridRect.RowCount; i++)
            {
                averageSquare += Convert.ToInt32(dataGridRect.Rows[i].Cells[1].Value);                
            }
            averageSquare = Convert.ToInt32(averageSquare / dataGridRect.RowCount - 1);

            for (int j = 0; j < dataGridRect.RowCount; j++)
            {
                if (Convert.ToInt32(dataGridRect.Rows[j].Cells[1].Value) > averageSquare)
                {
                    count++;
                }
            }
            forSearchButton.Text = averageSquare.ToString() + ": average square of rectangle" +'\n' + 
            "Rectangles which have larger Square than their sum: " + count.ToString();
        }
    }
}
