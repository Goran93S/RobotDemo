using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toy_Puzzle;

namespace RobotDemoWinApp
{
    public partial class Form1 : Form
    {
        Toy _Toy = new Toy();
        public Form1()
        {

            this.Paint += Draw2DArray;
            
            InitializeComponent();
            

            




        }
        public void Draw2DArray(object sender, PaintEventArgs e)
            {
               
                int step = 100; //distance between the rows and columns
                int width = 80; //the width of the rectangle
                int height = 80; //the height of the rectangle

                using (Graphics g = this.CreateGraphics())
                {
                    g.Clear(SystemColors.Control); //Clear the draw area
                    using (Pen pen = new Pen(Color.Blue, 2))
                    {
                        int rows = _Toy.table.GetUpperBound(0) + 1 - _Toy.table.GetLowerBound(0); 
                        int columns = _Toy.table.GetUpperBound(1) + 1 - _Toy.table.GetLowerBound(1); 

                        for (int index = 0; index < _Toy.table.Length; index++)
                        {
                            int i = index / columns;
                            int j = index % columns;
                            if (_Toy.table[i, j])
                            {
                                Rectangle rect = new Rectangle(new Point(5 + step * j, 5 + step * i), new Size(width, height));
                                g.DrawRectangle(pen, rect);
                                g.FillRectangle(System.Drawing.Brushes.Blue, rect);

                                
                            }
                            else
                            {
                                Rectangle rect = new Rectangle(new Point(5 + step * j, 5 + step * i), new Size(width, height));
                                g.DrawRectangle(pen, rect);
                                g.FillRectangle(System.Drawing.Brushes.Red, rect);


                            }
                        }

                        

                    }
                }
            }            

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) <= 4 && Convert.ToInt32(textBox1.Text) <= 4 && comboBox1.SelectedItem!=null)
            {
                _Toy.coordinate_X = Convert.ToInt32(textBox1.Text);
                _Toy.coordinate_Y = Convert.ToInt32(textBox2.Text);
                _Toy.Direction = comboBox1.SelectedItem.ToString();
                _Toy.TargetCoordinateX = _Toy.GenerateRandomCoordinate(0, 4);
                _Toy.TargetCoordinateY = _Toy.GenerateRandomCoordinate(0, 4);
                _Toy.Place();
                Paint += Draw2DArray;
                groupBoxEnters.Visible = false;
                groupBoxControls.Visible = true;
                labelDirectionInfo.Text = "Direction: " + _Toy.Direction;
                _Toy._Start = DateTime.Now;
            }
            else
                MessageBox.Show("Error! Wrong enters!");
        }

        public void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            
            _Toy.TurnLeft();
            labelDirectionInfo.Text = "Direction: "+_Toy.Direction;
            
            
        }

        public void buttonTurnRight_Click(object sender, EventArgs e)
        {        
            _Toy.TurnRight();
            labelDirectionInfo.Text ="Direction: "+ _Toy.Direction;                     
        }

        public void buttonMove_Click(object sender, EventArgs e)
        {           
            _Toy.Move();
            _Toy.Place();
            Paint += Draw2DArray;
            if (_Toy.Fall)
            {
                MessageBox.Show("GAME OVER");
                _Toy.GenerateRandomCoordinate(4, 4);
                ResetForm();
                _Toy.Fall = false;
            }

            if (_Toy.CheckMatching())
            {
                _Toy._Finish = DateTime.Now;
                TimeSpan timeSpan = _Toy._Finish - _Toy._Start;
                MessageBox.Show("FOUND! Time: "+ timeSpan.ToString("mm\\:ss\\:ff")+Environment.NewLine+
                    "Coordinates are: "+ _Toy.coordinate_X+","+_Toy.coordinate_Y);
                _Toy.GenerateRandomCoordinate(4,4);
                ResetForm();
               
            }
            buttonTurnLeft_Click(sender, e);
            buttonTurnRight_Click(sender, e);

        }
      
        public void ResetForm()
        {
            groupBoxEnters.Visible = true;
            groupBoxControls.Visible = false;
            
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\goran93\\Documents\\Visual Studio 2017\\Projects\\RobotDemoWinApp\\RobotDemoWinApp\\Resources\\RobotDemoPdfHelp.pdf");
        }

        
    }
}
