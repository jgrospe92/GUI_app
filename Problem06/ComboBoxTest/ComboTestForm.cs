using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxTest
{
    public partial class ComboTestForm : Form
    {
        public ComboTestForm()
        {
            InitializeComponent();
        }

        // get index of selected shape, draw shape
        private void imageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // create graphic object, Pen and SolidBrush
            using (Graphics myGraphics = base.CreateGraphics())

            // create Pen using color DarkRed
            using (Pen myPen = new Pen(Color.DarkRed))

            // create solidBrush using color DarkRed
            using (SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed))
            {
                // clear drawing area, setting it to color white
                myGraphics.Clear(Color.White);

                // find index, draw proper shape
                switch (imageComboBox.SelectedIndex)
                {
                    case 0: // case Circle is selected
                        myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                        break;
                    case 1: // Rectangle
                        myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                        break;
                    case 2: // Ellipse
                        myGraphics.DrawEllipse(myPen, 50, 85, 150, 115);
                        break;
                    case 3: 
                        myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                        break;
                    case 4: 
                        myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 150);
                        break;
                    case 5: 
                        myGraphics.FillRectangle(mySolidBrush, 50, 50, 150, 150);
                        break;
                    case 6: 
                        myGraphics.FillEllipse(mySolidBrush, 50, 85, 150, 115);
                        break;
                    case 7:
                        myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45);
                        break;
                }
            }
        }
    }
}
