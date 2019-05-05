using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string path = String.Empty;


        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle();
            parallelepiped = new Parallelepiped();
            var answer = MessageBox.Show("Do you want to open your data file ?", "Reader", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    openDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
                    path = openDialog.FileName;
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        using (BinaryReader stream = new BinaryReader(fs))
                        {
                            try
                            {
                                if (new FileInfo(path).Length != 0)
                                {
                                    foreach (char item in stream.ReadChars(500))
                                    {
                                        forSearchButton.Text += item;
                                    }
                                }
                            }
                            catch (EndOfStreamException ex)
                            {
                                forSearchButton.Text = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                fs.Close();
                                stream.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You don't use cached data");
            }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Do you want to cashe your information ?", "Cashe saver", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (String.IsNullOrWhiteSpace(richTextBox1.Text) == false && String.IsNullOrWhiteSpace(richTextBox2.Text) == false)
                {
                    SaveInformation(path);
                }
                else
                {
                    MessageBox.Show("Something going wrong!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void SaveInformation(string path)
        {
            if (path != null && File.Exists(path) == true)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    writer.Write(richTextBox1.Text);
                    writer.Write('\n');
                    writer.Write(richTextBox2.Text);
                    writer.Close();
                    MessageBox.Show("All information was wrote");
                }
            }
            else
            {
                MessageBox.Show("Path not exsist");
            }
        }

    }
}
