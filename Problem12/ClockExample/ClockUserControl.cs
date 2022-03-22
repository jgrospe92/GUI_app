using System;
using System.Windows.Forms;

namespace ClockExample
{
    public partial class ClockUserControl : UserControl
    {
        public ClockUserControl()
        {
            InitializeComponent();
        }

        // update label at every tick
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
